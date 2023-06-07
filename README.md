# quete-encapsulation
Une machine industrielle
Je veux que tu représentes une machine industrielle qui verse de la bière dans une bouteille puis l'encapsule. Le nom de la classe est BeerEncapsulator.

Le nombre de capsules dont la machine dispose doit être accessible en modification, ainsi que son nombre de bouteilles. En revanche, la quantité de bière disponible ne peut pas diminuer à l'extérieur de la machine, uniquement augmenter :

_avalaibleBeerVolume est un nombre décimal qui représente en centilitres le volume de bière disponible dans la machine

_avalaibleBottles est un nombre entier qui représente le nombre de bouteilles disponibles

_avalaibleCapsules est un nombre entier qui représente le nombre de capsules disponibles

Aucun attribut n'est accessible en-dehors de la classe, ils sont déclarés en private. On y accède de l'extérieur avec des accesseurs.

Une méthode AddBeer ajoute de la bière

Chaque bouteille est remplie de 33 centilitres de bière, nécessite une capsule et une bouteille. Lorsqu'une bouteille est réalisée, le nombre de composants diminue.

Dès qu'un composant manque, un message est affiché spécifiant la quantité d'un composant à ajouter nécessaire à la fabrication du nombre de bouteilles.

Une méthode ProduceEncapsulatedBeerBottles réalise la mise en bouteille:

Elle prend un seul argument: le nombre de bouteilles qu'elle doit fabriquer

Elle renvoie un entier: le nombre de bouteilles qui ont pu être faites

Si il n'y a pas assez de composants, la méthode renvoie 0