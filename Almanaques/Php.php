<?php

    // Para mandar errores (en mensaje) posibles
    init_set('display_errors', 1);
    init_set('display_startup_errors', 1);
    error_reporting(E_ALL);

    // Subir imagen (codificada en String)
    $ruta = "imagenes";
    $fi = fopen($ruta.'/'.$_POST['imgNom'],"a");
    fclose($fi);
  
    if(file_exists($ruta.'/'.$_POST['imgNom']))
    {
      $abrir = fopen($ruta.'/'.$_POST['imgNom'],'w');
      fwrite($abrir, base64_decode($_POST['imgBase']));
    }
?>