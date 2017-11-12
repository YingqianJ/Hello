#資料讀取

#實驗數據以data.csv存在桌面，在terminal移動到桌面後（cd desktop)
#運用pandas中的read_csv功能讀取data.csv至‘data’變數
import pandas as pd
data = pd.read_csv(‘data.csv’, sep = ‘,’, na_values = ‘.’)

#檢查數據的讀取（顯示有幾列幾行）（raw, column）
data.shape




#描述統計

#查看各組平均數
groupby_gender = data.groupby('gender')  #以gender變數來把資料分組
groupby_gender.mean() #顯示各變項兩組分別的平均數




#用scipy的stats進行t test

from scipy import stats

#對PM這一column的數據進行單一樣本t test
stats.ttest_1samp(data[‘PM’],0)

#獨立樣本t test，IV：gender，DV：PM
female_PM = data[data[‘gender’] == 2][‘PM’]
male_PM = data[data[‘gender’] == 1][‘PM’]
stats.ttest_ind(female_PM, male_PM)

#相依t，E和T的比較
stats.ttest_rel(data['sumE'], data['sumT'])

#用單一t做相依t（相減法）
stats.ttest_1samp(data[‘sumE’] - data[‘sumT’], 0)



#線性代數

import numpy as np
from scipy import linalg

#輸入矩陣a
a = np.array([[1,2],[3,4]])

#計算a的反矩陣
ia = linalg.inv(a)

#矩陣a乘以一個常數
b = 3*a

#矩陣乘法
c = np.dot(a, b)
i = np.dot(a, ia)

#矩陣轉置
a.T

#計算a的行列式值
det_a=linalg.det(a)



#（自己寫模组diy_linalg.py）
import diy_linalg as dl

#進行LU分解  （使用时 dl.LU( , )
def LU( , ):
    

#化為簡約列梯陣的方法（自己寫）
def Simple( , ):
    

#求A的n次的方法（自己寫）


#討論a, b, c, d關係的方法（自己寫）
