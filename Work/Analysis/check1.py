from sklearn.naive_bayes import GaussianNB
from sklearn import metrics
from sklearn.model_selection import train_test_split
import pandas as pd


data=pd.read_csv('forestfires.csv')


Y=data.temp
X=data.drop('temp',axis=1)

model = GaussianNB()
X_train, X_test, Y_train, Y_test = train_test_split(X,Y)
model.fit(X_train, Y_train)
