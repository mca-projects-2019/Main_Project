import sys
from PyQt5.QtCore import pyqtSlot
from PyQt5.QtWidgets import QApplication,QMainWindow,QDialog
from PyQt5.QtWidgets import QMessageBox
from PyQt5.uic import loadUi
from pymongo import MongoClient
from PyQt5.QtWidgets import QApplication, QWidget, QInputDialog, QLineEdit, QFileDialog,QVBoxLayout,QLabel
from PyQt5.QtGui import QIcon
from PyQt5.QtGui import QPixmap
from PyQt5.QtCore import *
import os 
from PyQt5 import QtCore, QtGui, QtWidgets 
from Main_PreProcessing import Pre_main
from struct_Analysis import Struct_Main


try: 
    conn = MongoClient()
    db = conn.uds
    collection = db.DF
    print("Connected successfully!!!") 
except:   
    print("Could not connect to MongoDB")

    

PRE=None

class Main_Home(QMainWindow):
    def __init__(self):
            super(Main_Home,self).__init__()
            loadUi('Home.ui',self)
            self.setWindowTitle('MineMax')

            self.setWindowIcon(QtGui.QIcon('logo.png'))
            
            
            self.central_widget = QWidget()               
            self.setCentralWidget(self.central_widget)    
            lay = QVBoxLayout(self.central_widget)

            label = QLabel(self)
            label.setAlignment(Qt.AlignCenter)
            pixmap = QPixmap('logo.png')
            label.setPixmap(pixmap)
            self.resize(pixmap.width(), pixmap.height())

            lay.addWidget(label)
            self.show()

            self.showMaximized()
            #self.setWindowIcon(QtGui.QIcon('logo.png'))

            self.actionSD.triggered.connect(self.openSD)
            
            self.actionOpen.triggered.connect(self.open_window)
            
            self.actionBox_Plot.triggered.connect(self.Boxplot)
            self.actionScatter_Plot.triggered.connect(self.Scatter)
            self.actionHistogram.triggered.connect(self.Histo)
           
            

            
            
    def open_window(self):
            global PRE
            fname = QFileDialog.getOpenFileName(self, 'Open file', 'D:\\')
            fname=fname[0]
            print(fname)
            fname=str(fname)
            PRE=Pre_main(fname)
            self.nd = Pre_Process_Window(self)
            self.nd.show()

    def openSD(self):
            self.nd = Struct_File(self)
            self.nd.show()
            
            

    def ret_window(self):
            self.nd = Retrieve_File(self)
            self.nd.show()
            
    def Boxplot(self):
            print("B ok")

    def Scatter(self):
            print("S ok")

    def Histo(self):
            print("H ok")


class Pre_Process_Window(QDialog):
    def __init__(self,parent):
	    super(Pre_Process_Window,self).__init__(parent)
	    loadUi('prepro.ui',self)
	    global PRE
	    print("okkkkkkkk")
	    print(PRE)
	    
	    
class Struct_File(QDialog):

    fname=""
    
    def __init__(self,parent):
	    super(Struct_File,self).__init__(parent)
	    loadUi('struct_analysis_base.ui',self)
	    self.resize(861,550)
	    print("okkkkkkkk struct analysis")
	    print('')
	    self.pushButton_2.setEnabled(False)

	    self.pushButton.clicked.connect(self.file_window)
	    self.pushButton_2.clicked.connect(self.SD_Analysis_Main)
	    
    def SD_Analysis_Main(self):
            global fname
            try:
                dreturn=Struct_Main(fname)
                
                
            except:
                QMessageBox.about(self, "Alert", "Please Choose a Correct File !!!!!!!")
    def file_window(self):

            try:
                global fname
                fname = QFileDialog.getOpenFileName(self, 'Open file', 'd:\\')
                fname=fname[0]
                fname_new_base=os.path.basename(fname)
                
                #self.label_3.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Expanding)
                #self.label_3.setAlignment(Qt.AlignCenter)
                self.label_3.setText(fname_new_base)
                self.pushButton_2.setEnabled(True)
                print(fname)
                fname=str(fname)
            except:
                print('error ret')
                
    
   
		



            
                
        

    


app=QApplication(sys.argv)
widget=Main_Home()
widget.show()
sys.exit(app.exec_())
