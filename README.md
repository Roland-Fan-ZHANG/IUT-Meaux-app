# IUT de Meaux APP
Une application multiplateforme entamé lors de mon stage en DUT MMI. Créer une visite virtuelle en reprenant le concept de Google Street View, pouvoir naviguer et visiter l'IUT de Meaux.

## Prérequis

- Installer UnityHub (gestionnaire de projets et d'installations Unity)
- Installer une version LTS de Unity (Long Term Support)
- Ajouter le module Android (optionnel si vous ne faites pas d'export)

## Mise en place du projet Unity sur votre machine 
- Cloner le projet via Github Desktop ou télécharger en ZIP puis l'extraire
- Lancer UnityHub
- Ouvrir le dossier du projet via UnityHub 
- Depuis l'éditeur Unity, lancer la scene 'Navigation' dans le dossier 'Scenes' si ce n'est pas le cas
- Pour tester, appuyer sur le bouton Play en haut de l'éditeur ou CTRL+P

## Exporter une version Android pour votre téléphone
- Depuis l'éditeur, aller sur l'onglet 'File' puis 'Build Settings'
- Ajouter la scene en cliquant sur 'Add Open Scenes' si ce n'est pas le cas
- Changer de platforme en cliquant sur Android puis 'Switch Platform' enfin 'Build'
### BONUS
Il est possible d'exporter sous d'autres plateformes, il faudra installer les modules en question puis changer la platforme.

## Pourquoi Android ?
Le système d'exploitation Android permet de tester nos projets bien plus facilement comparé à iOS par exemple. Mon choix c'est donc porté sur le mobile car il y a plus d'intérêt de déploiement.

