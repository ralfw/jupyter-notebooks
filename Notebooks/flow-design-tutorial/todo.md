# code für testbarkeit und verständlichkeit strukturieren
* vertical whitespace
* variablennamen
* funktionen
* dateien
* module (klassen->objekte)

# anforderung logik lücke
feature bzw bug einführen, das scheduled wird. dafür wird CT gemessen.
wie sieht die klammer-zu aus? das ist der test pro feature.

# gesamtprozess
alle phasen mit allen klammern einmal darstellen.
darin das kleinste ritzel identifizieren, mit dem die cycle time gemessen wird.
zb von analyse bis test. also pro inkrement auf jeden fall.
oder eher nach der analyse pro feature?



"Names are a form of abstraction: they provide a simplified way of thinking about a more complex underlying entity. Like other forms of abstraction, the best names are those that focus attention on what is most important about the underlying entity while omitting details that are less important.",
A Philosophy of Software Design
John Ousterhout

ein notebook für slicing


# slicing
nicht nur bis zur message, sondern auch bis zum feature. das kann im akzeptanztest repräsentiert sein - führt aber nicht unbedingt zu einer eigenen, neuen message.

# entwurf
stratified design
keine dark logik in der integration. der zusammenschluss der kindknoten ergibt den parentknoten. da bleibt nix offen. alles muss zueinander passen.

# codierung
## problemschwierigkeitsgrade
ohne akzeptantests kein produktionscode
## arbeitsteilung
für die codierung das modell heranziehen

# kritik
wo kann kritik geübt werden an zb:

* daily standups
* schätzungen
* velocity
* story points
* cTDD
