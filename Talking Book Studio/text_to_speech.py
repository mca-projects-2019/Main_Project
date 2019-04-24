from gtts import gTTS
import codecs
import os
APP_ROOT = os.path.dirname(os.path.abspath(__file__))
audio_path = r"C:\Users\PC\Desktop\Project\tintr\audio\first.mp3"

class TextToSpeech(object):

    def __init__(self):
        try:
            print("Text to speech class initilaized")
        except Exception as e:
            print(str(traceback.print_exc()))
            print("Exception occured",str(e))


    def text_to_speech(self, filepath):
        text = ""
        try:
            file = open(filepath, "rt", encoding="utf-8")
            text = file.read()
            tts = gTTS(text, lang='ml')
            file.close()
            tts.save(audio_path)
            os.system("good.mp3")

        except Exception as e:
            print("Exception occured:",str(e))
        return text


