require "lfs"  --����lua�ļ�ϵͳ��

dicTab = {}  --��������������ֵ ��ƥ����ֵ䣬�����滻�����еĺ�������
exegesisRows = {}  --���飬���ڴ洢��Ҫע�͵��е��к�
exegesisRowsCount = 0  --�����������ļ�����

--�ú������ڶ�ȡ�ļ������б��������� ��������������ֵ ��ƥ����ֵ䣨dicTab��
function FindStrAndReplaceStr(file1)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local fileTab = {}
	local line = file1:read()

	local row = 0  --�ļ����к�

	local findEvent1 = false     --��ʼѰ���¼�һ�Ķ����־
	local findEvent2 = false     --��ʼѰ���¼����Ķ����־
	local findEvent3 = false	 --��ʼѰ���¼����Ķ����־
	local findEvent4 = false	 --��ʼѰ���¼��ĵĶ����־
	local findEvent5 = false     --��ʼѰ���¼���Ķ����־

	local findValue1 = false     --��ʼѰ�ҵ�һ�� ��+=�� ��ֵ�ı�־
	local findValue2 = false     --��ʼѰ�ҵڶ��� ��+=�� ��ֵ�ı�־
	local findValue3 = false	 --��ʼѰ�ҵ����� ��+=�� ��ֵ�ı�־
	local findValue4 = false	 --��ʼѰ�ҵ��ĸ� ��+=�� ��ֵ�ı�־
	local findValue5 = false     --��ʼѰ�ҵ���� ��+=�� ��ֵ�ı�־

	local eventTab1 = nil        --
	local eventTab1 = nil        --
	local eventTab1 = nil	     --
	local eventTab1 = nil	     --
	local eventTab1 = nil        --

	local startRow = -1          --ע�Ϳ�ʼ����
	local endRow = -1            --ע�ͽ�������

	local eventCount = 0        --�¼���������¼�����˶��ٸ��¼�
	
	
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
	
	local fun_name = nil  --ƥ��ĺ���
	local ControlName = nil
		
	
	while line do
		row = row+1
		
		--��ʼѰ�ҵ���� +=
		if findValue5 then
			local valePos = string.find(line, "+=")  -- �ҵ� "+=" ��λ��
			if valePos then
				local pointPos = string.find(line, "%.")  -- �ҵ� "." ��λ��
				value5Name = string.sub(line, pointPos+1, valePos-2)
				print(value5Name,"�¼�����5")
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
		
		--��ʼѰ�ҵ��ĸ� +=
		if findValue4 then
			local valePos = string.find(line, "+=")  -- �ҵ� "+=" ��λ��
			if valePos then
				local pointPos = string.find(line, "%.")  -- �ҵ� "." ��λ��
				value4Name = string.sub(line, pointPos+1, valePos-2)
				--print(value4Name,"�¼�����4")
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

		--��ʼѰ�ҵ����� +=
		if findValue3 then
			local valePos = string.find(line, "+=")  -- �ҵ� "+=" ��λ��
			if valePos then
				local pointPos = string.find(line, "%.")  -- �ҵ� "." ��λ��
				value3Name = string.sub(line, pointPos+1, valePos-2)
				--print(value3Name,"�¼�����3")
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
		
		--��ʼѰ�ҵڶ��� +=
		if findValue2 then
			local valePos = string.find(line, "+=")  -- �ҵ� "+=" ��λ��
			if valePos then
				local pointPos = string.find(line, "%.")  -- �ҵ� "." ��λ��
				value2Name = string.sub(line, pointPos+1, valePos-2)
				--print(value2Name,"�¼�����2")
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
		
		--��ʼѰ�ҵ�һ�� +=
		if findValue1 then
			local valePos = string.find(line, "+=")  -- �ҵ� "+=" ��λ��
			if valePos then
				local pointPos = string.find(line, "%.")  -- �ҵ� "." ��λ��
				value1Name = string.sub(line, pointPos+1, valePos-2)
				--print(value1Name,"�¼�����1", line)
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

		--��ʼѰ�ҿؼ���
		if findControl then
			local midPos = string.find(line, "=")  -- �ҵ��Ⱥŵ�λ�ã�����ض�ȡǰ�벿��
			local preLine = string.sub(line, 0, midPos)  -- ��ȡǰ�벿��
			local haveThis = string.find(preLine, "this.")  -- ȷ���Ƿ��� ��this.��
			if haveThis then
				ControlName = string.sub(line, haveThis, midPos-2)
				--print(ControlName,"�ؼ���", line)
				findValue1 = true 
				findControl = false
			end
		end
		
		--��ʼѰ���¼���Ķ���
		if findEvent5 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event5name = string.sub(line, havenew+3, endPos)
				--print(event5name,"�¼��嶨��")
				eventCount = eventCount+1
				print("������¼��壿")
				findControl = true
			end
			findEvent5 = false
		end
		
		--��ʼѰ���¼��ĵĶ���
		if findEvent4 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event4name = string.sub(line, havenew+3, endPos)
				--print(event4name,"�¼��Ķ���")
				eventCount = eventCount+1
				findEvent5 = true
			else
				findControl = true
			end
			findEvent4 = false
		end
		
		--��ʼѰ���¼����Ķ���
		if findEvent3 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event3name = string.sub(line, havenew+3, endPos)
				--print(event3name,"�¼�������")
				eventCount = eventCount+1
				findEvent4 = true
			else
				findControl = true
			end
			findEvent3 = false
		end
		
		--��ʼѰ���¼����Ķ���
		if findEvent2 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event2name = string.sub(line, havenew+3, endPos)
				--print(event2name,"�¼�������")
				eventCount = eventCount+1
				findEvent3 = true
			else
				findControl = true
			end
			findEvent2 = false
		end
		
		--��ʼѰ���¼�һ�Ķ���
		if findEvent1 then
			local havenew = string.find(line, " = new ")
			if havenew then
				local endPos = string.find(line, ";")
				event1name = string.sub(line, havenew+3, endPos)
				--print(event1name,"�¼�һ����")
				startRow = row-4
				eventCount = eventCount+1
				findEvent2 = true

			end
							findEvent1 = false
		end
		
		--�ж��Ƿ��� ��{��
		if loge3 then
			local have = string.find(line, "{")
			if have then
				findEvent1 = true
			end
			loge3 = false
		end
		
		--�ж��Ƿ��� ��internal��
		if loge2 then
			local tempstart,tempend = string.find(line, "internal")
			if tempstart then
				local havevoid = string.find(line,"void")
				if havevoid then
					local havemethod = string.find(line,"od_")
					if havemethod==nil then
						--print(line)
									--print(line,"��Ҫ����")
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
	
		--�ж��Ƿ��� "[MethodImpl(MethodImplOptions.Synchronized)]"
		if loge0 then
			local have = string.find(line, "MethodImplOptions.Synchronized")
			if have then

				loge2 = true
			end
			loge0 = false
		end

		--�ж��Ƿ��� "[CompilerGenerated]"
		--print(line,"ԭ��")
		local loge1 = string.find(line, "%[CompilerGenerated%]")  -- �ж��Ƿ�
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
			-- local funname = string.sub(line,start+5,ends) --��Ҫ�滻�ĺ�����
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


--�ú�������д�ļ�
function writeFile(file1,fileTab)
	assert(file1,"file1 open failed")
	for i,line in ipairs(fileTab) do
		file1:write(line)
		file1:write("\n")
	end
end


--�޸�CS�ļ�
function fileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local row = 0  --�ļ����к�
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		
		--ѭ�����ҵ�һ��
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
			--print(line,"�������ַ���")
			
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
		end
		
		table.insert(fileTab,line)
		line = file1:read()
	end

	return fileTab
end

--��cs�ļ��еĺ��������ע��
function ExegesisCSFile(file1)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local row = 0  --�ļ����к�
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		
		for i,v in pairs(exegesisRows) do
			if v == row then
				line = "//"..line
				--print(v, row, line, "��������������")
			end
		end

		table.insert(fileTab,line)
		line = file1:read()
	end
	return fileTab
end


--�޸�Designer�ļ�
function desfileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local row = 0  --�ļ����к�
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		
		--ѭ�����ҵ�һ��
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
			print(line,"�������ַ���")
			
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


pathTab = {}  --�洢cs�ļ���Designer�ļ���

--ƥ��designer�ļ�
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

--����Ŀ¼
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


--�滻һ��cs�ļ���Designer�ļ�
function repalceFile(cspath,designerpath)
	--�ҵ�ƥ���ַ���
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
	
	--ע���ĵ��е��ļ�
	local fileRead = io.open(cspath,"r+") --���ļ����޸��ļ�����
	if fileRead then
		local tab = ExegesisCSFile(fileRead)
		fileRead:close()
		local fileWrite = io.open(cspath,"w")  --����д�ļ�������
		if fileWrite then
			writeFile(fileWrite,tab)
			fileWrite:close()
		end
	end
	
	exegesisRows = {}
	exegesisRowsCount = 0
	
	--�滻CS��DESIGNER�е��ַ���������dicTab��ʵ��
	for key,value in pairs(dicTab) do
		--print(key,value,"�ֵ�")
		--�滻cs�ļ��е��ַ���
		local fileRead = io.open(cspath,"r+") --���ļ����޸��ļ�����
		if fileRead then
			local tab = fileReplaceStr(fileRead, key, value)
			fileRead:close()
			local fileWrite = io.open(cspath,"w")  --����д�ļ�������
			if fileWrite then
				writeFile(fileWrite,tab)
				fileWrite:close()
			end
		end


		--�滻Designer�ļ��е��ַ���
		local fileRead = io.open(designerpath,"r+") --���ļ����޸��ļ�����
		if fileRead then
			local tab = desfileReplaceStr(fileRead, key, value)
			fileRead:close()
			local fileWrite = io.open(designerpath,"w")  --����д�ļ�������
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














