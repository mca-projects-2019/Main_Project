import numpy as NP  # Numpy Library


def ColorCorrection(img):
    red_COMP = img[:, :, 0]
    green_COMP = img[:, :, 1]
    blue_COMP = img[:, :, 2]
    alpha = 1

    red_MEAN = NP.mean(red_COMP)
    green_MEAN = NP.mean(green_COMP)
    blue_MEAN = NP.mean(blue_COMP)

    reconst_RED_COMP = red_COMP + alpha * (green_MEAN - red_MEAN) * (1 - red_COMP) * green_COMP
    reconst_BLUE_COMP = blue_COMP + alpha * (green_MEAN - blue_MEAN) * (1 - blue_COMP) * green_COMP

    ColorCorrectedImg = NP.zeros(img.shape)
    ColorCorrectedImg[:, :, 0] = reconst_RED_COMP
    ColorCorrectedImg[:, :, 1] = green_COMP
    ColorCorrectedImg[:, :, 2] = reconst_BLUE_COMP

    return ColorCorrectedImg


def GreyWorldAlgorithm(nimg):
    nimg = nimg.transpose(2, 0, 1).astype(NP.uint32)
    mu_g = NP.average(nimg[1])
    nimg[0] = NP.minimum(nimg[0] * (mu_g / NP.average(nimg[0])), 255)
    nimg[2] = NP.minimum(nimg[2] * (mu_g / NP.average(nimg[2])), 255)

    return nimg.transpose(1, 2, 0).astype(NP.uint8)
