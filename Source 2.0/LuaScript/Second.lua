require "lfs"  --����lua�ļ�ϵͳ��

dicTab = {}  --��������������ֵ ��ƥ����ֵ䣬�����滻�����еĺ�������
exegesisRows = {}  --���飬���ڴ洢��Ҫע�͵��е��к�
exegesisRowsCount = 0  --�����������ļ�����

--�ú������ڶ�ȡ�ļ������б��������� ��������������ֵ ��ƥ����ֵ䣨dicTab��
function FindStrAndReplaceStr(file1)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local fileTab = {}
	local line = file1:read()
	local returnpos = -1  --�ҵ�ƥ��ĺ�������return ������ڵ��кţ�row+2
	local row = 0  --�ļ����к�

	local fun_name = nil  --ƥ��ĺ���
	local startmatching = 0  --��ʼƥ���־

	while line do
		row = row+1
		if row==returnpos then
			local this = string.sub(line, 4, 7)
			if (this == "this") then
				deststrstart,deststrend = string.find(line, "=")
				local controlname = string.sub(line, 9, deststrstart-2)

				--��Ҫע�͵��кŴ�����
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
			local funname = string.sub(line,start+5,ends) --��Ҫ�滻�ĺ�����
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


--�ú�������д�ļ�
function writeFile(file1,fileTab)
	assert(file1,"file1 open failed")
	for i,line in ipairs(fileTab) do
		file1:write(line)
		file1:write("\n")
	end
end


justonce = 0
--�޸�CS�ļ�
function fileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local row = 0  --�ļ����к�
	local fileTab = {}
	local line = file1:read()
	while line do
		row = row+1
		if justonce == 0 then
			for i,v in pairs(exegesisRows) do
				if v == row then
					line = "//"..line
					--print(v, row, line, "��������������")
				end
			end
		end

		--this.vmethod_11(new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0));
		
		--ѭ�����ҵ�һ��
		local deststrstart,deststrend = string.find(line, "this."..key.."%(")
		if deststrstart then
			local temp1 = string.find(line, "%(")
			local temp2 = string.find(line, ";")
			local newcontrol = string.sub(line,temp1+1,temp2-2)
			local temp3 = string.find(line, "t")
			local strstart = string.sub(line, 0, temp3-1)
			line = strstart.."this."..value.." = "..newcontrol..";"
			print(line,"�������ַ���")
			
			local strmid = "this."..value
			local strend = string.sub(line,deststrend+1)
			
			
		end
		table.insert(fileTab,line)
		line = file1:read()
	end
	justonce = 1
	return fileTab
end


--�޸�Designer�ļ�
function desfileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local fileTab = {}
	local line = file1:read()
	--print(key,value,"ŶŶŶŶŶ")
	while line do
	
		--ѭ�����ҵ�һ��
		local deststrstart,deststrend = string.find(line, "this."..key.."%(")
		if deststrstart then
			local temp1 = string.find(line, "%(")
			local temp2 = string.find(line, ";")
			local newcontrol = string.sub(line,temp1+1,temp2-2)
			local temp3 = string.find(line, "t")
			local strstart = string.sub(line, 0, temp3-1)
			line = strstart.."this."..value.." = "..newcontrol..";"
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
	
	-- print("hehe")
	-- for key,value in pairs(dicTab) do 
		-- print(key,value,"hehe")
	-- end
	-- print("hehe")
	
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

		 exegesisRows = {}
		 exegesisRowsCount = 0
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














