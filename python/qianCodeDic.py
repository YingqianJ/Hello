#轉換為四進制
def transQua(dec,fourList):
  i=0
  while(dec>=1):
    fourList.append(i)
    fourList[i]=int(dec%4)
    dec=dec/4
    i=i+1
  return fourList

#轉換為27進制+自定符號
def code27(a):
  f=''
  i=0
  while(a/(27**i)>1):
    i=i+1  
  while(i>1):
    i=i-1
    c=a/(27**i)
    d=int(c)
    strd=str(d)
    code_d = code[strd]
    f = f+code_d
    a=a-d*(27**i)
    stra=str(a)
  code_a=code[stra]
  outcome=f+code_a
  return outcome

#以自定義符號代替0123
def code4(fourList):
  a=''
  for j in range(len(fourList)):
    temp = str(fourList[j])
    b=code[temp]
    a=b+a
  return a
    
#主程式
number = int(input('please enter a number:'))
myList =[]
code={'0':'@', '1':'a', '2':'b', '3':'c',
      '4':'d', '5':'e', '6':'f', '7':'g',
      '8':'h', '9':'i', '10':'j', '11':'k',
      '12':'l', '13':'m', '14':'n', '15':'o',
      '16':'p', '17':'q', '18':'r', '19':'s',
      '20':'t', '21':'u', '22':'v', '23':'w',
      '24':'x', '25':'y', '26':'z', 
     }
transQua(number,myList)
aa=code4(myList)
print('qianCode4  is:',aa)
bb=code27(number)
print('qianCode27 is:',bb)
