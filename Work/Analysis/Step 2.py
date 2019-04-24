import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression as lm
from sklearn.datasets import load_iris
import matplotlib.pyplot as plt

data=pd.read_csv('forestfires.csv')
pp=data.head()

#print(pp)

y=data.temp
x=data.drop('temp',axis=1)
#print(y)
#print(x)
x_train,x_test,y_train,y_test=train_test_split(x,y,test_size=0.2)
x_train.head()
#print(y_train.head())
#print(x_train.shape)

model=lm.fit(x_train,y_train)
predictions=lm.predict(x_test)


plt.scatter(y_test,predictions)
