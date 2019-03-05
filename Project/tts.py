from gtts import gTTS
import os
text='This quickstart introduces you to the Cloud Text-to-Speech API.In this quickstart, you set up your Google Cloud Platform project and authorization and then make a request for the Text-to-Speech API to create audio from text.'
tts = gTTS(text, lang='en')
tts.save("good.mp3")
os.system("mpg321 good.mp3")
