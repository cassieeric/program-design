# -*- coding: UTF-8 -*-
# 新建python文件，把该代码放进去，另外在相同路径下新建text.txt和text1.txt两个文件
# 把原始需要整理的题目复制粘贴到text.txt文件当中，运行python，text1.txt中就得到整理好的无重复题目。
# 打开原文件，按行取出文本，放入列表中
with open('text.txt', mode='r', encoding='utf-8') as f:
    list = f.readlines()
f.close()
print(list)
# 因为题干中有序号，选项中没有序号和.因此以有无.区别是不是题干。分离出每一道题干和选项，放入字典当中。
# 因为字典项目的唯一性，这样重复的题目就只会保留一个。
dict = {}
for line in list:
    if "." in line:
        key = line.split(".")[1]  # 去掉题干的序号，只保留主体
        dict[key] = []
    else:
        dict[key].append(line)
print(dict)
# 把字典写入目标文件中
num = 1
f = open("text1.txt", 'w', encoding='utf-8')
for k, v in dict.items():
    f.write(str(num) + "." + k)
    num = num+1
    for i in v:
        f.write(i)
f.close()
