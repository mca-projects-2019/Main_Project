from nltk.stem import WordNetLemmatizer
from nltk.tokenize import word_tokenize

def lemma(a):
    lemmatizer=WordNetLemmatizer()
    input_str=a
    input_str=word_tokenize(input_str)
    strx=""
    for word in input_str:
        strx += lemmatizer.lemmatize(word)
        strx +=""
    print(strx)
    return strx
