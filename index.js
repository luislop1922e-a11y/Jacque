document.addEventListener('DOMContentLoaded', () => {
    crearBurbujas();
    animarTitulo();
});
function crearBurbujas() {
    const contenedor = document.getElementById('bubblesContainer');
    for (let i = 0; i < 20; i++) {
        const burbuja = document.createElement('span');
        const tamano = Math.random() * 50 + 20;
        burbuja.style.width = `${tamano}px`; burbuja.style.height = `${tamano}px`;
        burbuja.style.left = `${Math.random() * 100}%`;
        burbuja.style.animation = `float ${Math.random() * 10 + 5}s infinite linear`;
        burbuja.style.position = 'absolute'; burbuja.style.bottom = '-100px';
        burbuja.style.background = 'rgba(255, 255, 255, 0.2)'; burbuja.style.borderRadius = '50%';
        contenedor.appendChild(burbuja);
    }
}
function animarTitulo() {
    document.querySelectorAll('.letter').forEach((letra) => {
        letra.addEventListener('mouseover', () => { letra.style.transform = 'scale(1.5) rotate(10deg)'; letra.style.color = '#ffd700'; });
        letra.addEventListener('mouseout', () => { letra.style.transform = 'scale(1) rotate(0deg)'; letra.style.color = ''; });
    });
}
