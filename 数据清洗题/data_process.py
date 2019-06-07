# -*- coding: utf-8 -*-
import numpy as np
import pandas as pd
from pandas import DataFrame, Series

data = pd.DataFrame(pd.read_excel('ok.xlsx'))
print(len(data))
examDf = DataFrame(data)
# examDf.duplicated(['citing', 'cited', 'weight'])
# print(examDf.duplicated(['citing', 'cited', 'weight']))
# examDf.drop_duplicates(['citing', 'cited', 'weight'])
# data.dropna()

