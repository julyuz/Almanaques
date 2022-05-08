"Error - 500 Server Error"
Yo tuve el mismo probelma al clonar un repositorio en homestead y esta fue mi solución.

El primer paso fue instalar composer

    composer install

Después cambiar el nombre del .env.example por .env

    mv .env.example .env

limpiar cache

    php artisan cache:clear

    composer dump-autoload

y por último generar el key

    php artisan key:generate

Yo obtuve la información de este video: https://youtu.be/2PHsbIS66H4

"No se puede ejecutar ''php artisan make:auth "
   composer require laravel/ui
   php artisan ui vue --auth  (en casso de usar Vue)
   php artisan migrate

ó poder user
   php artisan ui:auth
   
