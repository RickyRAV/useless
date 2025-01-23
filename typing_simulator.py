import keyboard
import time
import random

def simulate_typing(text, base_delay=0.4, variation=0.35, paragraph_pause=4.0):
    """
    Simulates human-like typing with configurable delays
    """
    print("Starting in 5 seconds... Move cursor to desired typing location.")
    time.sleep(10)
    
    for paragraph in text.split('\n\n'):
        for char in paragraph.strip():
            delay = base_delay + random.uniform(-variation, variation)
            time.sleep(delay)
            keyboard.write(char)
        
        time.sleep(paragraph_pause)
        keyboard.write('\n\n')

# Example usage
sample_text = """Klimaschutz als soziale Frage?

Sehr geehrte Damen und Herren,

die Klimakrise betrifft uns alle, jedoch in unterschiedlichem Ausmaß. Während wohlhabendere Bevölkerungsgruppen ihre Lebensweise oft problemlos an umweltfreundlichere Standards anpassen können, stoßen Menschen mit niedrigem Einkommen dabei auf immense Hürden. Ist Klimaschutz also eine Frage der sozialen Gerechtigkeit? Meiner Meinung nach – ja.

Ein Beispiel: Höhere Flugpreise und die Einführung von CO₂-Steuern sollen den Klimawandel eindämmen. Diese Maßnahmen treffen jedoch vor allem jene Menschen, die ohnehin selten fliegen oder auf günstige Produkte angewiesen sind. Eine wohlhabendere Familie kann sich trotz solcher Maßnahmen weiterhin Reisen leisten, während andere auf Mobilität und Lebensqualität verzichten müssen.

Daher ist es entscheidend, dass Klimaschutz sozial gestaltet wird. Es sollten Anreize geschaffen werden, die nachhaltiges Handeln fördern, ohne einkommensschwächere Schichten zu benachteiligen. Beispiele hierfür könnten Subventionen für öffentliche Verkehrsmittel, Förderprogramme für energieeffiziente Haushaltsgeräte oder günstigere Renovierungskredite für umweltfreundliche Wohnungen sein.

Zusätzlich sollte der Klimaschutz nicht nur als Belastung, sondern auch als Chance gesehen werden. Die Umstellung auf erneuerbare Energien und nachhaltige Technologien könnte Arbeitsplätze schaffen und langfristig die Lebensqualität aller verbessern. Dennoch darf dabei niemand zurückgelassen werden – sei es durch gezielte Bildungsinitiativen oder sozial gerechte Förderprogramme.

Abschließend ist Klimaschutz nicht nur eine ökologische, sondern auch eine soziale Verantwortung. Wenn wir diesen Wandel gemeinsam bewältigen wollen, müssen wir sicherstellen, dass alle Menschen – unabhängig von ihrem Einkommen – Teil der Lösung sein können. Nur so können wir eine gerechtere und nachhaltigere Zukunft schaffen.

Mit freundlichen Grüßen,
[DEIN NAME]"""  # Your full text here

simulate_typing(sample_text)