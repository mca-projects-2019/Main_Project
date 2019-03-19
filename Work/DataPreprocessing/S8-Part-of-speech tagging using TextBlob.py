input_str="Parts of speech examples: an article, to write, interesting, easily, and, of"
from textblob import TextBlob
result = TextBlob(input_str)
print(result.tags)
