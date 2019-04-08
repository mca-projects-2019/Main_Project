import sys
from PyQt5.QtCore import pyqtSlot
from PyQt5.QtWidgets import QApplication,QMainWindow,QDialog
from PyQt5.QtWidgets import QMessageBox
from PyQt5.uic import loadUi
from pymongo import MongoClient
from PyQt5.QtWidgets import QApplication, QWidget, QInputDialog, QLineEdit, QFileDialog
from PyQt5.QtGui import QIcon



try: 
    conn = MongoClient()
    db = conn.uds
    collection = db.DF
    print("Connected successfully!!!") 
except:   
    print("Could not connect to MongoDB")

    


class Main_Home(QMainWindow):
    def __init__(self):
            super(Main_Home,self).__init__()
            loadUi('Main_Home.ui',self)
            self.setWindowTitle('MineMax')
            #self.setWindowIcon(QtGui.QIcon('logo.png'))
            #self.actionInsert.clicked.connect(self.openDialog)
            
            self.actionOpen.triggered.connect(self.open_window)
            #self.actionRetrieve.triggered.connect(self.ret_window)
            

            
            
    def open_window(self):
            fname = QFileDialog.getOpenFileName(self, 'Open file', 'c:\\')
            fname=fname[0]
            print(fname)
            

    def ret_window(self):
            self.nd = Retrieve_File(self)
            self.nd.show()


   
		



            
                
        

    


app=QApplication(sys.argv)
widget=Main_Home()
widget.show()
sys.exit(app.exec_())
