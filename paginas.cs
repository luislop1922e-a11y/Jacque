* { margin: 0; padding: 0; box-sizing: border-box; }
body { font-family: 'Fredoka', sans-serif; background: linear-gradient(135deg, #667eea 0%, #764ba2 50%, #f093fb 100%); min-height: 100vh; position: relative; overflow-x: hidden; }
.magic { position: fixed; width: 100%; height: 100%; z-index: 0; top: 0; left: 0; pointer-events: none; }
.particle { position: absolute; border-radius: 50%; background: radial-gradient(circle, rgba(255,255,255,1) 0%, rgba(255,255,255,0) 70%); animation: sparkle 4s infinite ease-in-out; }
.particle:nth-child(1) { width: 8px; height: 8px; top: 20%; left: 10%; } .particle:nth-child(2) { width: 12px; height: 12px; top: 40%; left: 20%; animation-delay: 0.5s; }
.particle:nth-child(3) { width: 6px; height: 6px; top: 60%; left: 30%; animation-delay: 1s; } .particle:nth-child(4) { width: 10px; height: 10px; top: 30%; left: 40%; animation-delay: 1.5s; }
@keyframes sparkle { 0%, 100% { opacity: 0; transform: translateY(0) scale(1); } 50% { opacity: 1; transform: translateY(-30px) scale(1.5); } }
nav { background: rgba(255, 255, 255, 0.95); padding: 1rem 2rem; box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1); position: relative; z-index: 100; }
.nav-links { display: flex; gap: 1rem; flex-wrap: wrap; justify-content: center; }
.nav-links a { text-decoration: none; color: #764ba2; font-weight: 600; padding: 0.5rem 1rem; border-radius: 20px; transition: all 0.3s; }
.nav-links a:hover { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; transform: translateY(-2px); }
.header { text-align: center; padding: 3rem 1rem; color: white; position: relative; z-index: 1; }
.header h1 { font-family: 'Righteous', cursive; font-size: 3.5rem; margin-bottom: 1rem; text-shadow: 0 0 20px rgba(255,255,255,0.5); }
.container { max-width: 1200px; margin: 0 auto; padding: 2rem; position: relative; z-index: 1; }
.content-box { background: rgba(255, 255, 255, 0.95); padding: 2rem; border-radius: 20px; margin-bottom: 2rem; box-shadow: 0 8px 32px rgba(118, 75, 162, 0.3); }
.content-box h2 { color: #764ba2; margin-bottom: 1rem; font-size: 2rem; }
.gallery { display: grid; grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); gap: 1.5rem; }
.img-card { border-radius: 15px; overflow: hidden; box-shadow: 0 4px 15px rgba(118, 75, 162, 0.4); transition: all 0.3s; background: white; }
.img-card:hover { transform: translateY(-10px) scale(1.02); }
.img-card img { width: 100%; height: 250px; object-fit: cover; }
.caption { padding: 1rem; text-align: center; font-weight: 600; color: #764ba2; }
.submenu-area { text-align: center; margin: 2rem 0; }
.submenu-btn { display: inline-block; padding: 1.5rem 3rem; background: linear-gradient(135deg, #667eea 0%, #764ba2 50%, #f093fb 100%); color: white; text-decoration: none; border-radius: 50px; font-weight: 600; }
footer { background: rgba(0, 0, 0, 0.8); color: white; text-align: center; padding: 2rem; margin-top: 3rem; position: relative; z-index: 1; }
