from S1 import tolower
from S3 import rem_punct
from S5 import stopword_rem
from S6 import stemming_pro
from S7 import lemma


def Pre_main(fx):
    
    f1=open(fx,'r+')
    p=f1.read()

    print("------Base Data------\n")
    print(p)
    print("\n")

    print("------After Lower Case Processing------\n")
    x=tolower(p) #Convert to Lower Case Letters
    print("\n")

    print("------After Punctuation Removal------\n")
    x=rem_punct(x) #Removing Punctuations
    print("\n")

    print("------After Stopword Removal------\n")
    x=stopword_rem(x) #Removing Stopwords
    print("\n")

    print("------After Stemming------\n")
    x=stemming_pro(x) #Stemming
    print("\n")

    print("------After Lemmatization------\n")
    x=lemma(x) #Lemmatization
    print("\n")














