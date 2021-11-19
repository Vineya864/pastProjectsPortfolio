import os

tasks=" Playbooks tasks"+"\n"+"-----------------"+"\n"
vars=" Playbooks vars"+"\n"+"-----------------"+"\n"
defaults=" Default vars"+"\n"+"-----------------"+"\n"
handler=" Playbooks handlers"+"\n"+"-----------------"+"\n"
playbookPath=input ("File Location: ")
print( "/"+playbookPath+"/README.md")
playbookName=input("Playbook name: ")
if ((os.path.isdir(playbookPath+'/tasks')) and (os.path.isfile(playbookPath+'/tasks/main.yml'))):
    handleFlag=0
    file = open(playbookPath+'/tasks/main.yml', 'r')
    for line in file:
        if(handleFlag==0):
            if ("- name:" in line):
                tasks=tasks +"\n"+ line.replace("name:", " ").strip()
            elif("handler" in line):
                handleFlag=1
        else:
            if ("- name:" in line):
                handler=handler +"\n"+ line.replace("name:", " ").strip()
            elif ("name" in line):
                handler=handler+ "\n task:"+line.strip()
            
    file.close
if ((os.path.isdir(playbookPath+'/vars')) and (os.path.isfile(playbookPath+'/vars/main.yml'))):  
    file = open(playbookPath+'/vars/main.yml', 'r')
    for line in file:
            if (" - " not in line and "---" not in line):
                vars=vars+"\n"+line.strip()
    file.close
    
if ((os.path.isdir(playbookPath+'/defaults')) and (os.path.isfile(playbookPath+'/defaults/main.yml'))):  
    file = open(playbookPath+'defaults/main.yml', 'r')
    for line in file:
            if (" - " not in line and "---" not in line):
                defaults=defaults+"\n"+line.strip()
                temp=line.strip().split(":")
                vars=vars+"\n"+temp[0].replace("- ","")
    file.close
if ((os.path.isdir(playbookPath+'/handlers')) and (os.path.isfile(playbookPath+'/handlers/main.yml'))):  
    file = open(playbookPath+'vars/main.yml', 'r')
    for line in file:
        if ("- name:" in line):
            handler=handler +"\n"+ string.strip((line.replace("name:", " ")))
    file.close


f = open(playbookPath+"README.md", "a")
f.write(playbookName+"\n"+"=============="+"\n"+"\n"+"\n"+tasks+"\n"+"\n"+vars+"\n"+"\n"+defaults+"\n"+"\n"+"\n"+handler)
f.close()

if (os.path.isfile('README.md')):
    print ("README Created")

