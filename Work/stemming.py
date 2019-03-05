import nltk
from nltk.stem.porter import PorterStemmer
porter_stemmer = PorterStemmer()

word_data = "In the areas of Natural Language Processing we come across situation where two or more words have a common root"
# First Word tokenization
nltk_tokens = nltk.word_tokenize(word_data)
#Next find the roots of the word
for w in nltk_tokens:
       print ("Actual: %s  Stem: %s"  % (w,porter_stemmer.stem(w)))
