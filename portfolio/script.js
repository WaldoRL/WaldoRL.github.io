const $Gmail = document.getElementById('mail');

function CopiarCorreo() {
    navigator.clipboard.writeText('walter.rosaless06@gmail.com')
}

$Gmail.addEventListener('click',function() {
   $Gmail.textContent = 'copiado!';

setTimeout(function(){
    $Gmail.textContent = 'Email';
},  700);

});