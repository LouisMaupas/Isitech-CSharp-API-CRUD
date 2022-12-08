# Isitech-CSharp-API-CRUD

Pour lancer le projet :
```C#
dotnet run --launch-profil https
```

J'ai oublié de traiter ces questions dans le 1er projet. 

1) Utillité des classes abstraites et des interfaces.<br />
Une classe ne peut hériter que d’une seule classe parente (abstraite ou non), mais implémenter plusieurs interfaces.
Les classes abstraites ne sont pas instanciables, elles servent avant tout à factoriser du code,
en pratique on les utilisent pour définir la forme des classes enfant sans en définir le fond.
Dans une interface les méthodes sont déclarés sans se préoccuper comment les classes se chargeront d'y implémenter. 

Voir exemple dans fichier question.cs


2) Pourquoi il y a des portées dans les languages. <br />
Les niveaux d'accès servent à garantir l'intégrité du code et éviter les erreurs lors de l'utilisation de la classe. 
Ca peut être utile lorsque plusieurs développeurs travaillent sur une même application pour éviter les erreurs de modification involontaire,
en exposant uniquement ce qui a besoin d'être modifié.