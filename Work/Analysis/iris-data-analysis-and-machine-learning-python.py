import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import matplotlib
import seaborn as sns
sns.set(color_codes=True)


df = pd.read_csv('Iris.csv')
print(df.head())

if 'Id' in df.columns:
  df.__delitem__('Id')

df.head()

x=df.shape
cols=x[1]
rows=x[0]
print("No. of Columns \t: "+str(cols))
print("No. of Rows \t: "+str(rows))

#print(df.info())

#print()

#print(df['species'].unique())

#print(df.describe())

df.describe()

listOfColumns = df.columns
listOfNumericalColumns = []

"""

for column in listOfColumns:
    if df[column].dtype == np.float64:
        listOfNumericalColumns.append(column)

print('listOfNumericalColumns :',listOfNumericalColumns)
spices = df['species'].unique()
print('spices :',spices)

fig, axs = plt.subplots(nrows=len(listOfNumericalColumns),ncols=len(spices),figsize=(15,15))

for i in range(len(listOfNumericalColumns)):
    for j in range(len(spices)):  
        print(listOfNumericalColumns[i]," : ",spices[j])
        axs[i,j].boxplot(df[listOfNumericalColumns[i]][df['species']==spices[j]])
        axs[i,j].set_title(listOfNumericalColumns[i]+""+spices[j]) 
"""
df.plot(kind='box')
df.hist(figsize=(10,5))
plt.show()

spices = df['species'].unique()
print("HIST PLOT OF INDIVIDUAL Species")
print(spices)


"""for spice in spices:
        df[df['species']==spice].hist(figsize=(10,5))"""
df.boxplot(by='species',figsize=(15,15))

#df.plot(kind='box')
#df.hist(figsize=(10,5))
#plt.show()

print(sns.violinplot(data=df,x='species',y='petal_length'))
plt.show()






