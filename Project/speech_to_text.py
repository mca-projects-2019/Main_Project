import traceback
import speech_recognition as sr
import pyaudio
import codecs
import os
r= sr.Recognizer()
APP_ROOT = os.path.dirname(os.path.abspath(__file__))
text_path = r"C:\Users\PC\Desktop\Project\views\text\first.txt"

class SpeechTotext(object):

    def __init__(self):
        try:
            print("Speech to test class initilaized")
        except Exception as e:
            print(str(traceback.print_exc()))
            print("Exception occured",str(e))

    def speech_to_text(self, filepath):
        text = ""
        try:
            harvard = sr.AudioFile(filepath)
            with harvard as source:
                # print('say something')
                audio = r.listen(source)
                r.adjust_for_ambient_noise(source)
            text = r.recognize_google(audio, language='ml')
            print("text",text)
            file = open(text_path, "w", encoding="utf-8")
            file.write(text)
            file.close()
        except Exception as e:
            print("Exception occured:",str(e))
        return text
