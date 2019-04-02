import pywt
import pywt.data

def SWT(img):

    return pywt.swt2(img,'db2',level=3)