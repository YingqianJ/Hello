
#轉換為二進制
def transBin(b,myList):
  i=0
  while(b>=1):
    myList.append(i)   #使空白陣列擁有i個位置
    myList[i]=int(b%2) #取餘數
    b=b/2
    i = i+1
  return myList
    
#轉換為四進制
def transQua(a,myList):
  i=0
  while(a>=1):
    myList.append(i)   #使空白陣列擁有i個位置
    myList[i]=int(a%4) #取餘數
    a=a/4
    i = i+1
  return myList

#輸出
def output(myList):
  j=int(len(myList))
  while(j>0):
      j=j-1
      print(myList[j],end='')
    
#主程式    
dec = int(input('please enter a number:\n'))
print('decimal is:\n',dec)
print('binary is:\n', bin(dec))
print('hexadecimal is:\n',hex(dec))
binList =[] #給二進制用的陣列
quaList=[]  #給四進制用的陣列
dec2=dec    #給四進制用的數

#轉換為二進制
transBin(dec,binList)
print('binary is:\n 0b',end='')
output(binList)

#轉換為四進制
transQua(dec2,quaList)
print('\nquadratic is:\n ',end='')
output(quaList)
