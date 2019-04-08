from nltk.corpus import stopwords
#from sklearn.feature_extraction.stop_words import ENGLISH_STOP_WORDS
#from spacy.lang.en.stop_words import STOP_WORDS
from nltk.tokenize import word_tokenize 
  
def stopword_rem(a):
    text_data = a
      
    stop_words = set(stopwords.words('english')) 
      
    word_tokens = word_tokenize(text_data) 
      
    filtered_sentence = [w for w in word_tokens if not w in stop_words] 
      
    filtered_sentence ="" 
      
    for w in word_tokens: 
        if w not in stop_words:
            filtered_sentence +=w
            filtered_sentence +=" "
            
    print(filtered_sentence)
    return filtered_sentence
