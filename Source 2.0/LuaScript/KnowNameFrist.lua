require "lfs"  --����lua�ļ�ϵͳ��

dicTab = {}  --��������������ֵ ��ƥ����ֵ䣬�����滻�����еĺ�������
exegesisRows = {}  --���飬���ڴ洢��Ҫע�͵��е��к�
exegesisRowsCount = 0  --�����������ļ�����

--�ú������ڶ�ȡ�ļ������б��������� ��������������ֵ ��ƥ����ֵ䣨dicTab��
function readFile(file1)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local fileTab = {}
	local line = file1:read()

	local row = 0  --�ļ����к�

	local loge1 = false
	local loge2 = false
	local loge3 = false
	local loge4 = false
	local loge5 = false

	local funname = nil
	local controlname = nil

	while line do
		row = row+1

		--�ж��Ƿ��� ��return��
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

		--�ж��Ƿ��� ��return��
		if loge4 then
			local have,endpos = string.find(line, "return")
			if have then
				local temp1 = string.find(line, ";")
				controlname = string.sub(line,endpos+2,temp1-1)
				loge5 = true
			end
			loge4 = false
		end

		--�ж��Ƿ��� ��{��
		if loge3 then
			local have = string.find(line, "{")
			if have then
				loge4 = true
			end
			loge3 = false
		end

		--�ж��Ƿ��� ��internal��
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
							--print(funname,"����")
							loge3 = true
						end
					end
				end
			end
			loge2 = false
		end

		--�ж��Ƿ��� "[CompilerGenerated]"
		local loge1 = string.find(line, "[CompilerGenerated]")  -- �ж��Ƿ�
		if loge1 then
			loge2 = true
			loge1 = false
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
--�ú���ͨ���ֵ��еļ�ֵ�����滻�ļ����õ��ú����ĵط�
function fileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local row = 0  --�ļ����к�
	local fileTab = {}
	local line = file1:read()
	--print(key,value,"ŶŶŶŶŶ")
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

		--ѭ�����ҵ�һ��
		local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
		if deststrstart then
			local strstart = string.sub(line,0,deststrstart-1)

			local strmid = value
			local strend = string.sub(line,deststrend+1)
			line = strstart..strmid..strend
			--ѭ�����ҵڶ���
			local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
			if deststrstart then
				local strstart = string.sub(line,0,deststrstart-1)
				local strmid = value
				local strend = string.sub(line,deststrend+1)
				line = strstart..strmid..strend
				--ѭ�����ҵ�����
				local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
				if deststrstart then
					local strstart = string.sub(line,0,deststrstart-1)
					local strmid = value
					local strend = string.sub(line,deststrend+1)
					line = strstart..strmid..strend
				end
			end
			print(line,"�������ַ���")
		end
		table.insert(fileTab,line)
		line = file1:read()
	end
	justonce = 1
	return fileTab
end


--�ú���ͨ���ֵ��еļ�ֵ�����滻�ļ����õ��ú����ĵط�
function desfileReplaceStr(file1, key, value)
	assert(file1,"file1 open failed-�ļ���ʧ��")
	local fileTab = {}
	local line = file1:read()
	while line do

		--ѭ�����ҵ�һ��
		local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
		if deststrstart then
			local strstart = string.sub(line,0,deststrstart-1)
			local strmid = value
			local strend = string.sub(line,deststrend+1)
			line = strstart..strmid..strend
			--ѭ�����ҵڶ���
			local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
			if deststrstart then
				local strstart = string.sub(line,0,deststrstart-1)
				local strmid = value
				local strend = string.sub(line,deststrend+1)
				line = strstart..strmid..strend
				--ѭ�����ҵ�����
				local deststrstart,deststrend = string.find(line, "this."..key.."%(%)")
				if deststrstart then
					local strstart = string.sub(line,0,deststrstart-1)
					local strmid = value
					local strend = string.sub(line,deststrend+1)
					line = strstart..strmid..strend
				end
			end
			print(line,"�������ַ���")
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

--Ѱ��designer�ļ���·��
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

--��ȡ�ļ�·��������·����
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














