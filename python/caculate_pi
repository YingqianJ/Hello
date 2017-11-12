import random

def numberGen(myList,a):
    i=0
    while(i < a):
        myList.append(i)
        myList[i]=random.random()
        i=i+1
    return myList

def countNum(xxList,yyList,a):
    count=0
    i=0
    while(i<a):
      if xxList[i]**2+yyList[i]**2<=1:
        count = count + 1
      i=i+1
    return count

xList=[]
yList=[]
numbers=10000000.0
numberGen(xList,numbers)
numberGen(yList,numbers)
counts=countNum(xList,yList,numbers)
pi=counts/numbers*4
print (pi)
