from nltk.stem import PorterStemmer
from nltk.tokenize import word_tokenize

def stemming_pro(a):
    stemmer= PorterStemmer()
    input_str=a
    strx=""
    input_str=word_tokenize(input_str)
    for word in input_str:
        strx += stemmer.stem(word)
        strx +=" "

    print (strx)
    return strx

    
