require "lfs"  --请求lua文件系统库

dicTab = {}  --函数名——返回值 相匹配的字典，用于替换代码中的函数调用
exegesisRows = {}  --数组，用于存储需要注释的行的行号
exegesisRowsCount = 0  --上面这个数组的计数器

--该函数用于读取文件并逐行便利来构建 函数名——返回值 相匹配的字典（dicTab）
function FindStrAndReplaceStr(file1)
	assert(file1,"file1 open failed-文件打开失败")
	local fileTab = {}
	local line = file1:read()

	local row = 0  --文件中行号

	local findEvent1 = false     --开始寻找事件一的定义标志
	local findEvent2 = false     --开始寻找事件二的定义标志
	local findEvent3 = false	 --开始寻找事件三的定义标志
	local findEvent4 = false	 --开始寻找事件四的定义标志
	local findEvent5 = false     --开始寻找事件五的定义标志

	local findValue1 = false     --开始寻找第一个 “+=” 赋值的标志
	local findValue2 = false     --开始寻找第二个 “+=” 赋值的标志
	local findValue3 = false	 --开始寻找第三个 “+=” 赋值的标志
	local findValue4 = false	 --开始寻找第四个 “+=” 赋值的标志
	local findValue5 = false     --开始寻找第五个 “+=” 赋值的标志

	local eventTab1 = nil        --
	local eventTab1 = nil        --
	local eventTab1 = nil	     --
	local eventTab1 = nil	     --
	local eventTab1 = nil        --

	local startRow = -1          --注释开始行数
	local endRow = -1            --注释结束行数

	local eventCount = 0        --事件个数，记录定义了多少个事件
	
	
	local event1name
	local event2name
	local event3name
	local event4name
	local event5name
	
	local value1name
	local value2name
	local value3name
	local value4name
	local value5name
	
	local fun_name = nil  --匹配的函数
	local ControlName = nil
		
	
	while line do
		row = row+1
		
		--开始寻找第五个 +=
		if findValue5 then
			local valePos = string.find(line, "+=")  -- 找到 "+=" 的位置
			if valePos then
				local pointPos = string.find(line, "%.")  -- 找到 "." 的位置
				value5Name = string.sub(line, pointPos+1, valePos-2)
				print(value5Name,"事件属性5")
				eventCount = eventCount-1
				if eventCount == 0 then
					endRow = row +2
					while startRow<=endRow do
						exegesisRows[exegesisRowsCount] = startRow
						exegesisRowsCount = exegesisRowsCount + 1
						startRow = startRow+1
					end
					dicTab[fun_name] = ControlName.."ABC"..ControlName.."."..value1Name.." += "..event1name..
									   ControlName.."."..value2Name.." += "..event2name..
									   ControlName.."."..value3Name.." += "..event3name..
									   ControlName.."."..value4Name.." += "..event4name..
									   ControlName.."."..value5Name.." += "..event5name
				end
				findValue5 = false
			end
		end
		
		--开始寻找第四个 +=
		if findValue4 then
			local valePos = string.find(line, "+=")  -- 找到 "+=" 的位置
			if valePos then
				local pointPos = string.find(line, "%.")  -- 找到 "." 的位置
				value4Name = string.sub(line, pointPos+1, valePos-2)
				--print(value4Name,"事件属性4")
				eventCount = eventCount-1
				if eventCount == 0 then
					endRow = row +2
					
					while startRow<=endRow do
						exegesisRows[exegesisRowsCount] = startRow
						exegesisRowsCount = exegesisRowsCount + 1
						startRow = startRow+1
					end
					
					dicTab[fun_name] = ControlName.."ABC"..ControlName.."."..value1Name.." += "..event1name..
									   ControlName.."."..value2Name.." += "..event2name..
									   ControlName.."."..value3Name.." += "..event3name..
									   ControlName.."."..value4Name.." += "..event4name
				else
					findValue5 = true 
				end
				findValue4 = false
			end
		end

		--开始寻找第三个 +=
		if findValue3 then
			local valePos = string.find(line, "+=")  -- 找到 "+=" 的位置
			if valePos then
				local pointPos = string.find(line, "%.")  -- 找到 "." 的位置
				value3Name = string.sub(line, pointPos+1, valePos-2)
				--print(value3Name,"事件属性3")
				eventCount = eventCount-1
				if eventCount == 0 then
					endRow = row +2
					
					while startRow<=endRow do
						exegesisRows[exegesisRowsCount] = startRow
						exegesisRowsCount = exegesisRowsCount + 1
						startRow = startRow+1
					end
					
					dicTab[fun_name] = ControlName.."ABC"..ControlName.."."..value1Name.." += "..event1name..
									   ControlName.."."..value2Name.." += "..event2name..
									   ControlName.."."..value3Name.." += "..event3name
				else
					findValue4 = true 
				end
				findValue3 = false
			end
		end
		
		--开始寻找第二个 +=
		if findValue2 then
			local valePos = string.find(line, "+=")  -- 找到 "+=" 的位置
			if valePos then
				local pointPos = string.find(line, "%.")  -- 找到 "." 的位置
				value2Name = string.sub(line, pointPos+1, valePos-2)
				--print(value2Name,"事件属性2")
				eventCount = eventCount-1
				if eventCount == 0 then
					endRow = row +2
					
					while startRow<=endRow do
						exegesisRows[exegesisRowsCount] = startRow
						exegesisRowsCount = exegesisRowsCount + 1
						startRow = startRow+1
					end
					
					dicTab[fun_name] = ControlName.."ABC"..ControlName.."."..value1Name.." += "..event1name..
									   ControlName.."."..value2Name.." += "..event2name
				else
					findValue3 = true 
				end
				findValue2 = false
			end
		end
		
		--开始寻找第一个 +=
		if findValue1 then
			local valePos = string.find(line, "+=")  -- 找到 "+=" 的位置
			if valePos then
				local pointPos = string.find(line, "%.")  -- 找到 "." 的位置
				value1Name = string.sub(line, pointPos+1, valePos-2)
				--print(value1Name,"事件属性1", line)
				eventCount = eventCount-1
				if eventCount == 0 then
					endRow = row +2
					
					while startRow<=endRow do
						exegesisRows[exegesisRowsCount] = startRow
						exegesisRowsCount = exegesisRowsCount + 1
						startRow = startRow+1
					end
					
					--print(fun_name,ControlName)
					dicTab[fun_name] = ControlName.."ABC"..ControlName.."."..value1Name.." += "..event1name
				else
					findValue2 = true 
				end
				findValue1 = false
			end
		end

		--开始寻找控件名
		if findControl then
			local midPos = string.find(line, "=")  -- 找到等号的位置，将其截断取前半部分
			local preLine = string.sub(line, 0, midPos)  -- 截取前半部分
			local haveThis = string.find(preLine, "this.")  -- 确定是否有 “this.”
			if haveThis then
				ControlName = string.sub(line, haveThis, midPos-2)
				--print(ControlName,"控件名", line)
				findValue1 = true 
				findControl = false
			end
		end
		
		--开始寻找事件五的定义
		if findEvent5 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event5name = string.sub(line, havenew+3, endPos)
				--print(event5name,"事件五定义")
				eventCount = eventCount+1
				print("真的有事件五？")
				findControl = true
			end
			findEvent5 = false
		end
		
		--开始寻找事件四的定义
		if findEvent4 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event4name = string.sub(line, havenew+3, endPos)
				--print(event4name,"事件四定义")
				eventCount = eventCount+1
				findEvent5 = true
			else
				findControl = true
			end
			findEvent4 = false
		end
		
		--开始寻找事件三的定义
		if findEvent3 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event3name = string.sub(line, havenew+3, endPos)
				--print(event3name,"事件三定义")
				eventCount = eventCount+1
				findEvent4 = true
			else
				findControl = true
			end
			findEvent3 = false
		end
		
		--开始寻找事件二的定义
		if findEvent2 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event2name = string.sub(line, havenew+3, endPos)
				--print(event2name,"事件二定义")
				eventCount = eventCount+1
				findEvent3 = true
			else
				findControl = true
			end
			findEvent2 = false
		end
		
		--开始寻找事件一的定义
		if findEvent1 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event1name = string.sub(line, havenew+3, endPos)
				--print(event1name,"事件一定义")
				startRow = row-4
				eventCount = eventCount+1
				findEvent2 = true

			end
							findEvent1 = false
		end
		
		--判断是否有 “{”
		if loge3 then
			local have = string.find(line, "{")
			if have then
				findEvent1 = true
			end
			loge3 = false
		end
		
		--判断是否有 “internal”
		if loge2 then
			local tempstart,tempend = string.find(line, "internal")
			if tempstart then
				local havevoid = string.find(line,"void")
				if havevoid then
					local havemethod = string.find(line,"od_")
					if havemethod==nil then
						--print(line)
									--print(line,"需要的行")
						local temp1start = string.find(line, "%(")
						if temp1start then
							fun_name = string.sub(line,havevoid+5,temp1start-1)
							loge3 = true
						end
					end
				end
			end
			loge2 = false
		end
	
		--判断是否有 "[MethodImpl(MethodImplOptions.Synchronized)]"
		if loge0 then
			local have = string.find(line, "MethodImplOptions.Synchronized")
			if have then

				loge2 = true
			end
			loge0 = false
		end

		--判断是否有 "[CompilerGenerated]"
		--print(line,"原文")
		local loge1 = string.find(line, "%[CompilerGenerated%]")  -- 判断是否
		if loge1 then

			loge0 = true
			loge1 = false
			
			loge2 = false
			loge3 = false
			
			local findEvent1 = false
			local findEvent2 = false
			local findEvent3 = false
			local findEvent4 = false
			local findEvent5 = false

			local findValue1 = false
			local findValue2 = false
			local findValue3 = false
			local findValue4 = false
			local findValue5 = false
		end
		
		-- local start,ends = string.find(line, "void vmethod_[0-9]*%(")
		-- if start then
			-- local funname = string.sub(line,start+5,ends) --需要替换的函数名
			-- fun_name = funname..")"
			-- startRow = -1 
			-- endRow = -1   
			-- findEvent1 = true
			-- eventRow = row + 2
		-- end

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


--修改CS文件
function fileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-文件打开失败")
	local row = 0  --文件中行号
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		
		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(")
		if deststrstart then
			local temp1 = string.find(line, "%(")
			local temp2 = string.find(line, ";")
			local newcontrol = string.sub(line,temp1+1,temp2-2)
			
			local ctrlstart,ctrlend = string.find(value,"ABC")
			local ctrlname = string.sub(value,0,ctrlstart-1)
			local eventcode = string.sub(value, ctrlend+1)
			local headcut = string.sub(line,0,deststrstart-1)
			line = headcut..ctrlname.." = "..newcontrol..";"..eventcode
			--print(line,"重组后的字符串")
			
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
		end
		
		table.insert(fileTab,line)
		line = file1:read()
	end

	return fileTab
end

--对cs文件中的函数体进行注释
function ExegesisCSFile(file1)
	assert(file1,"file1 open failed-文件打开失败")
	local row = 0  --文件中行号
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		
		for i,v in pairs(exegesisRows) do
			if v == row then
				line = "//"..line
				--print(v, row, line, "哈哈，你死定了")
			end
		end

		table.insert(fileTab,line)
		line = file1:read()
	end
	return fileTab
end


--修改Designer文件
function desfileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-文件打开失败")
	local row = 0  --文件中行号
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		
		--循环查找第一遍
		local deststrstart,deststrend = string.find(line, "this."..key.."%(")
		if deststrstart then
			local temp1 = string.find(line, "%(")
			local temp2 = string.find(line, ";")
			local newcontrol = string.sub(line,temp1+1,temp2-2)
			
			local ctrlstart,ctrlend = string.find(value,"ABC")
			local ctrlname = string.sub(value,0,ctrlstart-1)
			local eventcode = string.sub(value, ctrlend+1)
			local headcut = string.sub(line,0,deststrstart-1)
			line = headcut..ctrlname.." = "..newcontrol..";"..eventcode
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
	
	--print("hehe")
	--for key,value in pairs(dicTab) do 
	--	print(key,value,"hehe")
	--end
	--print("xixixixixixixixixixixixixix")
	
	--注释文档中的文件
	local fileRead = io.open(cspath,"r+") --读文件并修改文件内容
	if fileRead then
		local tab = ExegesisCSFile(fileRead)
		fileRead:close()
		local fileWrite = io.open(cspath,"w")  --重新写文件并保存
		if fileWrite then
			writeFile(fileWrite,tab)
			fileWrite:close()
		end
	end
	
	exegesisRows = {}
	exegesisRowsCount = 0
	
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
	--BrowseScenarioPlatforms
	--CampaignPlayWindow
	local path = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.cs"
	local path2 = "E:\\Command\\CommandX\\Source 2.0\\CommandX\\Command\\MainForm.Designer.cs"
		repalceFile(path,path2)
	--	dicTab = {}
	--end
end


main()














