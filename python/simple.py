x = 0
y = 1
n = 1
i = 0
while (i == 0):
    x = x + (n-1)/2.0
    y = n*y
    if  (x*x+y*y>=36):
        print x,y
        i = 1
    else:
        n = n + 1
a = y/x
print a
