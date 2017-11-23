# coding: utf - 8
import requests

#request the page
page = requests.get('https://scholar.google.com/citations?user=1kt2b0wAAAAJ&hl=en&oi=ao')

#or
#link = "https://scholar.google.com/citations?user=1kt2b0wAAAAJ&hl=en&oi=ao"
#page = requests.get(link)


#--use XPath--
from lxml import html

#对获取到的page格式化操作，以让XPath来解析
tree = html.fromstring(page.text)

#XPath解析，获取你要的文字段落
cit_all_raw = tree.xpath('//td[@class="gsc_rsb_std"]/text()')
cit_20_raw = tree.xpath('//a[@class="gsc_a_ac gs_ibl"]/text()')
year_20_raw = tree.xpath('//span[@class="gsc_a_h gsc_a_hc gs_ibl"]/text()')
cit_year_raw = tree.xpath('//span[@class="gsc_g_al"]/text()')
#data = tree.xpath('//div[@class="gs_gray"]/text()')

#转换为数字
cit_all = [int(x) for x in cit_all_raw]
cit_20 = [int(x) for x in cit_20_raw]
year_20 = [int(x) for x in year_20_raw]
cit_year = [int(x) for x in cit_year_raw]


#输出为csv
import numpy as np
import pandas as pd
#data1_前20引用数量及年份
a = np.vstack([cit_20, year_20])

df = pd.DataFrame(a)
df.to_csv('cit_20.csv',index = False)

#data2_各种关于引用量的数据
cit_all.extend(cit_year)
df_all = pd.DataFrame(cit_all)
df_all.to_csv('cit_all.csv', index = False)



#--use BeautifulSoup--
from bs4 import BeautifulSoup

soup = BeautifulSoup(page.text, "lxml")
#b = soup.prettify()  
#print(b) show the html page in a more beautiful way

pr_name = soup.html.head.title
citation = soup.find_all("td", class_="gsc_rsb_std")

#show the results
print(titleTag)
print(title)

name = str(pr_name)
cit = str(citation)

#save the information as txt
with open('cit.txt',"a+") as f:
    f.write(cit)
    f.close()
