import speech_recognition as sr
import pyaudio
r= sr.Recognizer()

with sr.Microphone() as source:
    print('say something')
    audio = r.listen(source)

try:
    print('Google thinks you said\n' + r.recognize_google(audio))

except:
    pass
