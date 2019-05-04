# -*- coding: utf-8 -*-
"""

"""
import matplotlib.pyplot as plt
import pandas as pd
import numpy as np
from sklearn import svm
from sklearn.svm import SVC
from sklearn.model_selection import train_test_split as tts
from sklearn.metrics import confusion_matrix as cm  
from sklearn.metrics import classification_report as cr  
from sklearn.model_selection import cross_val_score, GridSearchCV
import seaborn as sns
from sklearn.utils import shuffle
import pylab as pl


dataset=pd.read_csv(r'newdataset - Sheet1.csv')
print (dataset.size)
print(dataset)
newdata=dataset.drop('Place',axis=1)
places=dataset['Place']
xtrain,ytest,ytrain,xtest=tts(newdata,places,test_size=0.2)
print(xtrain.shape)
print(ytest.shape)
try:
    svmmodel=SVC(gamma=0.01,kernel='linear')
    svmmodel.fit(xtrain,ytrain)
    predict=svmmodel.predict(ytest)
    print(ytest)
    print(predict)
    print('Confusion matrix',cm(xtest,predict))
    print(cr(xtest,predict))
except ValueError as e:
    print('Error',e)