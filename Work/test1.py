import sys
from PyQt5.QtCore import pyqtSlot
from PyQt5.QtWidgets import QApplication,QMainWindow
from PyQt5.uic import loadUi

class Main_Home(QMainWindow):
	def __init__(self):
		super(Main_Home,self).__init__()
		loadUi('Main_Home.ui',self)
		self.setWindowTitle('MineMax')
		self.setWindowIcon(QtGui.QIcon('logo.png'))

app=QApplication(sys.argv)
widget=Main_Home()
widget.show()
sys.exit(app.exec_())
