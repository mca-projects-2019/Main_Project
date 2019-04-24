import pandas
from pandas.plotting import scatter_matrix
import matplotlib.pyplot as plt
from sklearn import model_selection
from sklearn.metrics import classification_report
from sklearn.metrics import confusion_matrix
from sklearn.metrics import accuracy_score
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
from sklearn.neighbors import KNeighborsClassifier
from sklearn.discriminant_analysis import LinearDiscriminantAnalysis
from sklearn.naive_bayes import GaussianNB
from sklearn.svm import SVC
import os.path



def Struct_Main(dname):
    try:
        extension = os.path.splitext(dname)[1]
        print(extension)

        if (extension=='.csv'):
            print('working on csv')
            dataset = pandas.read_csv(dname)
            a=dataset.head()
            c=dataset.describe()
            print(a)
            print('----------------------------------\n\n')
            print(c)
            
                        
        else:
            print('NOT CSV FILE ')

        
    except:
        print("csv error !!!!!!!!!!!!!")


        #f.close()

    
"""dataset = pandas.read_csv('iris.csv')

a=dataset.head() #to check the first 10 rows of the data set
b=dataset.tail() #to check out last 10 row of the data set
c=dataset.describe() #to give a statistical summary about the dataset
d=dataset.sample(5) #pops up 5 random rows from the data set 
e=dataset.isnull().sum() #checks out how many null info are on the dataset
print(a)
print(b)
print(c)
print(d)
print(e)
print()

if 'FID' in dataset.columns:
  dataset.__delitem__('FID')

print(c)


#Visualization

dataset.plot(kind='box', subplots=True, layout=(2,2), sharex=False, sharey=False)
plt.show()# Box-Plot

dataset.hist()
plt.show() #Histogram

scatter_matrix(dataset)
plt.show() #Scatter_plott


# Split-out validation dataset
array = dataset.values
X = array[:,0:4]
Y = array[:,4]
validation_size = 0.20
seed = 7
X_train, X_validation, Y_train, Y_validation = model_selection.train_test_split(X, Y, test_size=validation_size, random_state=seed)

seed = 7
scoring = 'accuracy'

# Spot Check Algorithms
models = []
models.append(('LR', LogisticRegression()))
# evaluate each model in turn
results = []
names = []
for name, model in models:
 kfold = model_selection.KFold(n_splits=10, random_state=seed)
 cv_results = model_selection.cross_val_score(model, X_train, Y_train, cv=kfold, scoring=scoring)
 results.append(cv_results)
 names.append(name)
 msg = "%s: %f (%f)" % (name, cv_results.mean(), cv_results.std())
 print(msg)"""








