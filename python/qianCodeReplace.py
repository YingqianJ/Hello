#轉換為四進制
def transQua(dec,fourList):
  i=0
  while(dec>=1):
    fourList.append(i)
    fourList[i]=int(dec%4)
    dec=dec/4
    i=i+1
  return fourList

#以自定義符號代替0123
def transCode(qianCode,fourList):
  for j in range(len(fourList)):
    qianCode.append(j)
    qianCode[j]=str(fourList[j])
    qianCode[j]=qianCode[j].replace("0","@")
    qianCode[j]=qianCode[j].replace("1","a")
    qianCode[j]=qianCode[j].replace("2","b")
    qianCode[j]=qianCode[j].replace("3","c")
    
#輸出
def output(qianCode):
  print('qianCode is: ',end='')
  j=len(qianCode)
  while(j>0):
    j=j-1
    print(qianCode[j],end='')
  print()
  
  
#主程式
a = int(input('please enter a number:'))
myList =[]
myCode =[]
transQua(a,myList)
transCode(myCode,myList)
output(myCode)
