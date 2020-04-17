require "lfs"  --请求lua文件系统库

dicTab = {}  --函数名——返回值 相匹配的字典，用于替换代码中的函数调用
exegesisRows = {}  --数组，用于存储需要注释的行的行号
exegesisRowsCount = 0  --上面这个数组的计数器

--该函数用于读取文件并逐行便利来构建 函数名——返回值 相匹配的字典（dicTab）
function readFile(file1)
	assert(file1,"file1 open failed-文件打开失败")
		--print("hello lua")
	local fileTab = {}
	local line = file1:read()
	local returnpos = -1  --找到匹配的函数名后，return 语句所在的行号，row+2
	local row = 0  --文件中行号

	local fun_name  --匹配的函数
	--local return_str  --正则表达式匹配函数中返回的控件
	local startmatching = 0  --开始匹配标志

	while line do
		--print("get line 获取行内容：",line)
		row = row+1
		if row==returnpos then
			local deststrstart,deststrend = string.find(line, "return this.")
			local temp1start = string.find(line, "s")
			local temp2start = string.find(line, ";")
			if deststrstart then
				local retname = string.sub(line,temp1start+2,temp2start-1)  --取出该函数返回的控件名

				--将要注释的行号存起来
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

				--print(row, retname, "你妹")
				dicTab[fun_name] = retname
				fun_name = nil
				startmatching = 0
				--line = string.gsub(line, "this","ABCDEFG")
			end
		end
		local start,ends = string.find(line, "vmethod_[0-9]*%(%)")
		if start then
			local funname = string.sub(line,start,ends)
			fun_name = funname
			returnpos = row + 2
			if startmatching == 0 then
				--print(fun_name)
				startmatching = 1
			end
		end
		table.insert(fileTab,line)
		line = file1:read()
	end
	-- print(fileTab[91])
	-- print(fileTab[120])
	-- print(fileTab[146])
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
--该函数通过字典中的键值对来替换文件中用到该函数的地方
function fileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-文件打开失败")
	local row = 0  --文件中行号
	local fileTab = {}
	local line = file1:read()
	--print(key,value,"哦哦哦哦哦")
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

		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
		if deststrstart then
			local strstart = string.sub(line,0,deststrstart-1)
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
			line = strstart..strmid..strend
			--循环查找第二遍
			local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
			if deststrstart then
				local strstart = string.sub(line,0,deststrstart-1)
				local strmid = "this."..value
				local strend = string.sub(line,deststrend+1)
				line = strstart..strmid..strend
				--循环查找第三遍
				local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
				if deststrstart then
					local strstart = string.sub(line,0,deststrstart-1)
					local strmid = "this."..value
					local strend = string.sub(line,deststrend+1)
					line = strstart..strmid..strend
				end
			end
			print(line,"重组后的字符串")
		end
		table.insert(fileTab,line)
		line = file1:read()
	end
	justonce = 1
	return fileTab
end


--该函数通过字典中的键值对来替换文件中用到该函数的地方
function desfileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-文件打开失败")
	local fileTab = {}
	local line = file1:read()
	--print(key,value,"哦哦哦哦哦")
	while line do
	
		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
		if deststrstart then
			local strstart = string.sub(line,0,deststrstart-1)
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
			line = strstart..strmid..strend
			--循环查找第二遍
			local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
			if deststrstart then
				local strstart = string.sub(line,0,deststrstart-1)
				local strmid = "this."..value
				local strend = string.sub(line,deststrend+1)
				line = strstart..strmid..strend
				--循环查找第三遍
				local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
				if deststrstart then
					local strstart = string.sub(line,0,deststrstart-1)
					local strmid = "this."..value
					local strend = string.sub(line,deststrend+1)
					line = strstart..strmid..strend
				end
			end
			print(line,"重组后的字符串")
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

--寻找designer文件的路径
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

--读取文件路径，构建路径对
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
		local tab = readFile(fileRead)
		fileRead:close()
		local fileWrite = io.open(cspath,"w")
		if fileWrite then
			writeFile(fileWrite,tab)
			fileWrite:close()
		end
	end
	
	--for key,value in pairs(dicTab) do 
	--	print(key,value,"hehe")
	--end
	
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
	-- --local path = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.cs"
	-- --local path2 = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.Designer.cs"
		-- repalceFile(key,value)
		-- dicTab = {}
	-- end
	local path = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.cs"
	local path2 = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.Designer.cs"
		repalceFile(path,path2)
end


main()














