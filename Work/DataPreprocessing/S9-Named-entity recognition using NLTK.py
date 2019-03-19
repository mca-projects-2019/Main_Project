from nltk import word_tokenize, pos_tag, ne_chunk
input_str = "Bill works for Apple so he went to Boston for a conference."
print (ne_chunk(pos_tag(word_tokenize(input_str))))
