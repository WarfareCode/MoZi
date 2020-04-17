require "lfs"  --请求lua文件系统库

dicTab = {}  --函数名——返回值 相匹配的字典，用于替换代码中的函数调用
exegesisRows = {}  --数组，用于存储需要注释的行的行号
exegesisRowsCount = 0  --上面这个数组的计数器

--该函数用于读取文件并逐行便利来构建 函数名——返回值 相匹配的字典（dicTab）
function readFile(file1)
	assert(file1,"file1 open failed-文件打开失败")
	local fileTab = {}
	local line = file1:read()

	local row = 0  --文件中行号

	local loge1 = false
	local loge2 = false
	local loge3 = false
	local loge4 = false
	local loge5 = false

	local funname = nil
	local controlname = nil

	while line do
		row = row+1

		--判断是否有 “return”
		if loge5 then
			local have = string.find(line, "}")
			if have then

				exegesisRows[exegesisRowsCount] = row-4
				exegesisRowsCount = exegesisRowsCount + 1

				exegesisRows[exegesisRowsCount] = row-3
				exegesisRowsCount = exegesisRowsCount + 1

				exegesisRows[exegesisRowsCount] = row-2
				exegesisRowsCount = exegesisRowsCount + 1

				exegesisRows[exegesisRowsCount] = row-1
				exegesisRowsCount = exegesisRowsCount + 1

				exegesisRows[exegesisRowsCount] = row
				exegesisRowsCount = exegesisRowsCount + 1

				dicTab[funname] = controlname
			end
			loge5 = false
		end

		--判断是否有 “return”
		if loge4 then
			local have,endpos = string.find(line, "return")
			if have then
				local temp1 = string.find(line, ";")
				controlname = string.sub(line,endpos+2,temp1-1)
				loge5 = true
			end
			loge4 = false
		end

		--判断是否有 “{”
		if loge3 then
			local have = string.find(line, "{")
			if have then
				loge4 = true
			end
			loge3 = false
		end

		--判断是否有 “internal”
		if loge2 then
			local tempstart,tempend = string.find(line, "internal")
			if tempstart then
				local havevoid = string.find(line,"void")
				if havevoid == nil then
					local havemethod = string.find(line,"od_")
					if havemethod==nil then
						local temp1start = string.find(line, "%(")
						if temp1start then
							local temp2 = string.sub(line,tempend+3,temp1start-1)
							local temp3start = string.find(temp2,"%s")
							funname = string.sub(temp2,temp3start+1)
							--print(funname,"哈哈")
							loge3 = true
						end
					end
				end
			end
			loge2 = false
		end

		--判断是否有 "[CompilerGenerated]"
		local loge1 = string.find(line, "[CompilerGenerated]")  -- 判断是否
		if loge1 then
			loge2 = true
			loge1 = false
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

			local strmid = value
			local strend = string.sub(line,deststrend+1)
			line = strstart..strmid..strend
			--循环查找第二遍
			local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
			if deststrstart then
				local strstart = string.sub(line,0,deststrstart-1)
				local strmid = value
				local strend = string.sub(line,deststrend+1)
				line = strstart..strmid..strend
				--循环查找第三遍
				local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
				if deststrstart then
					local strstart = string.sub(line,0,deststrstart-1)
					local strmid = value
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
	while line do

		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
		if deststrstart then
			local strstart = string.sub(line,0,deststrstart-1)
			local strmid = value
			local strend = string.sub(line,deststrend+1)
			line = strstart..strmid..strend
			--循环查找第二遍
			local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
			if deststrstart then
				local strstart = string.sub(line,0,deststrstart-1)
				local strmid = value
				local strend = string.sub(line,deststrend+1)
				line = strstart..strmid..strend
				--循环查找第三遍
				local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
				if deststrstart then
					local strstart = string.sub(line,0,deststrstart-1)
					local strmid = value
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

--~ 	for key,value in pairs(dicTab) do
--~ 		print(key,value,"hehe")
--~ 	end

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
	--roadFilePath("E:\\Command\\CommandX\\Source 2.0\\CommandX") --
	--for key,value in pairs(pathTab) do
	--	justonce = 0
	--AddSatellite.cs
	--MainForm.cs
	--AirOps
	--BrowseScenarioPlatforms
	--CampaignPlayWindow
	local path = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.cs"
	local path2 = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.Designer.cs"
		repalceFile(path,path2)
	--	dicTab = {}
	--end
end


main()














