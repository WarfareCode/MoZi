require "lfs"  --请求lua文件系统库

dicTab = {}  --函数名——返回值 相匹配的字典，用于替换代码中的函数调用
exegesisRows = {}  --数组，用于存储需要注释的行的行号
exegesisRowsCount = 0  --上面这个数组的计数器

--该函数用于读取文件并逐行便利来构建 函数名——返回值 相匹配的字典（dicTab）
function FindStrAndReplaceStr(file1)
	assert(file1,"file1 open failed-文件打开失败")
	local fileTab = {}
	local line = file1:read()
	local returnpos = -1  --找到匹配的函数名后，return 语句所在的行号，row+2
	local row = 0  --文件中行号

	local fun_name = nil  --匹配的函数
	local startmatching = 0  --开始匹配标志

	while line do
		row = row+1
		if row==returnpos then
			local this = string.sub(line, 4, 7)
			if (this == "this") then
				deststrstart,deststrend = string.find(line, "=")
				local controlname = string.sub(line, 9, deststrstart-2)

				--将要注释的行号存起来
				exegesisRows[exegesisRowsCount] = row - 4
				exegesisRowsCount = exegesisRowsCount + 1
				exegesisRows[exegesisRowsCount] = row - 3
				exegesisRowsCount = exegesisRowsCount + 1
				exegesisRows[exegesisRowsCount] = row - 2
				exegesisRowsCount = exegesisRowsCount + 1
				exegesisRows[exegesisRowsCount] = row - 1
				exegesisRowsCount = exegesisRowsCount + 1
				exegesisRows[exegesisRowsCount] = row
				exegesisRowsCount = exegesisRowsCount + 1
				exegesisRows[exegesisRowsCount] = row + 1
				exegesisRowsCount = exegesisRowsCount + 1
				
				--print(controlname,fun_name,line)
				dicTab[fun_name] = controlname
				fun_name = nil
				startmatching = 0
				returnpos = -1
			end
		end
		local start,ends = string.find(line, "void vmethod_[0-9]*%(")
		if start then
			local funname = string.sub(line,start+5,ends) --需要替换的函数名
			fun_name = funname..")"
			returnpos = row + 2
			if startmatching == 0 then
				startmatching = 1
			end
		end
		table.insert(fileTab,line)
		line = file1:read()
	end
	return fileTab
end


--该函数用于写文件
function writeFile(file1,fileTab)
	assert(file1,"file1 open failed")
	for i,line in ipairs(fileTab) do
		file1:write(line)
		file1:write("\n")
	end
end


justonce = 0
--修改CS文件
function fileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-文件打开失败")
	local row = 0  --文件中行号
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		if justonce == 0 then
			for i,v in pairs(exegesisRows) do
				if v == row then
					line = "//"..line
					--print(v, row, line, "哈哈，你死定了")
				end
			end
		end

		--this.vmethod_11(new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0));
		
		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(")
		if deststrstart then
			local temp1 = string.find(line, "%(")
			local temp2 = string.find(line, ";")
			local newcontrol = string.sub(line,temp1+1,temp2-2)
			local temp3 = string.find(line, "t")
			local strstart = string.sub(line, 0, temp3-1)
			line = strstart.."this."..value.." = "..newcontrol..";"
			print(line,"重组后的字符串")
			
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
			
			
		end
		table.insert(fileTab,line)
		line = file1:read()
	end
	justonce = 1
	return fileTab
end


--修改Designer文件
function desfileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-文件打开失败")
	local fileTab = {}
	local line = file1:read()
	--print(key,value,"哦哦哦哦哦")
	while line do
	
		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(")
		if deststrstart then
			local temp1 = string.find(line, "%(")
			local temp2 = string.find(line, ";")
			local newcontrol = string.sub(line,temp1+1,temp2-2)
			local temp3 = string.find(line, "t")
			local strstart = string.sub(line, 0, temp3-1)
			line = strstart.."this."..value.." = "..newcontrol..";"
			print(line,"重组后的字符串")
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
		end

		table.insert(fileTab,line)
		line = file1:read()
	end
	return fileTab
end


function getfilename(str)
	local idx = str:match(".+()%.%w+$")
	if (idx) then
		return str:sub(1, idx-1)
	else
		return str
	end
end


function getextension(str)
	return str:match(".+%.(%w+)$")
end


pathTab = {}  --存储cs文件和Designer文件对

--匹配designer文件
function findDesignerfile(rootpath, str, cspath)
	for entry in lfs.dir(rootpath) do
		if entry ~= '.' and entry ~= '..' then
			local path = rootpath..'\\'..entry
			local attr = lfs.attributes(path)
			local filename = getfilename(entry)
			if attr.mode ~= 'directory' then
				local postfix = getextension(entry)
				if (postfix == "cs") then
					local csname = str..".Designer.cs"
					--print(csname,entry)
					if entry == csname then
						pathTab[cspath] = path
					end
				end
			else
				roadFilePath(path)
			end
		end
	end
end

--遍历目录
function roadFilePath(rootpath)
	for entry in lfs.dir(rootpath) do
		if entry ~= '.' and entry ~= '..' then
			local path = rootpath..'\\'..entry
			local attr = lfs.attributes(path)
			local filename = getfilename(entry)
			if attr.mode ~= 'directory' then
				local postfix = getextension(entry)
				if (postfix == "cs") then
					findDesignerfile(rootpath, filename, path)
				end
			else
				roadFilePath(path)
			end
		end
	end
end


--替换一对cs文件和Designer文件
function repalceFile(cspath,designerpath)
	--找到匹配字符串
	local fileRead = io.open(cspath,"r+")
	if fileRead then
		local tab = FindStrAndReplaceStr(fileRead)
		fileRead:close()
		local fileWrite = io.open(cspath,"w")
		if fileWrite then
			writeFile(fileWrite,tab)
			fileWrite:close()
		end
	end
	
	-- print("hehe")
	-- for key,value in pairs(dicTab) do 
		-- print(key,value,"hehe")
	-- end
	-- print("hehe")
	
	--替换CS和DESIGNER中的字符串，遍历dicTab来实现
	for key,value in pairs(dicTab) do
		--print(key,value,"字典")
		--替换cs文件中的字符串
		local fileRead = io.open(cspath,"r+") --读文件并修改文件内容
		if fileRead then
			local tab = fileReplaceStr(fileRead, key, value)
			fileRead:close()
			local fileWrite = io.open(cspath,"w")  --重新写文件并保存
			if fileWrite then
				writeFile(fileWrite,tab)
				fileWrite:close()
			end
		end

		 exegesisRows = {}
		 exegesisRowsCount = 0
		--替换Designer文件中的字符串
		local fileRead = io.open(designerpath,"r+") --读文件并修改文件内容
		if fileRead then
			local tab = desfileReplaceStr(fileRead, key, value)
			fileRead:close()
			local fileWrite = io.open(designerpath,"w")  --重新写文件并保存
			if fileWrite then
				writeFile(fileWrite,tab)
				fileWrite:close()
			end
		end

	end
end


function main()
	-- roadFilePath("E:\\Command\\CommandX\\Source 2.0\\CommandX") --
	-- for key,value in pairs(pathTab) do
		-- justonce = 0
	-- --AddSatellite.cs
	-- --MainForm.cs
	--BrowseScenarioPlatforms
	-- --local path = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.cs"
	-- --local path2 = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.Designer.cs"
		-- repalceFile(key,value)
		-- dicTab = {}
	-- end
	
	local path = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\AttackTarget.cs"
	local path2 = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\AttackTarget.Designer.cs"
		repalceFile(path,path2)
end


main()














