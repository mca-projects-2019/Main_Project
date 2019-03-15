from textblob import TextBlob
text=open("ONE.txt")
text=text.read()
text=text[0:200]
blob=TextBlob(text)

print(blob.translate(to="ml"))
