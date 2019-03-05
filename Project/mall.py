import speech_recognition as sr
import pyaudio
r= sr.Recognizer()

with sr.Microphone() as source:
    print('say something')
    audio = r.listen(source)
    print('done')

text=r.recognize_google(audio,language='ml')
print(text)
print(r.recognize_google(audio))
