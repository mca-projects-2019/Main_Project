
import cv2 as CV



def ImageResample(inputImg,refImg):

    rzRefImg = CV.resize(refImg,(256,256))
    rzInpImg = CV.resize(inputImg,(256,256))

    return (rzRefImg,rzInpImg)





