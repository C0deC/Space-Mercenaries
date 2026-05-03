# Space Mercenaries

Juego 2D desarrollado en Unity, inspirado en el clásico estilo "lunar lander". El objetivo es pilotar una nave espacial y aterrizar suavemente en plataformas mientras gestionas combustible, recoges monedas y evitas impactos bruscos.

## Descripción

Space Mercenaries es un prototipo de videojuego que combina físicas 2D con mecánicas de vuelo y aterrizaje. El jugador controla un módulo espacial que debe:

- Mantener el combustible bajo control.
- Girar y usar propulsores para estabilizar la nave.
- Aterrizar en plataformas seguras.
- Evitar aterrizajes demasiado rápidos, con ángulos incorrectos o fuera de la zona de aterrizaje.
- Recoger monedas y potenciadores de combustible.
- Superar niveles con múltiples terrenos y cámaras dinámicas.

## Nuevas implementaciones

- Sistema de niveles con progreso secuencial y carga de escenas `GameScene`, `MainMenuScene` y `GameOverScene`.
- Cámara con seguimiento dinámico y zoom adaptado a cada nivel usando `CinemachineCameraZoom2D`.
- Calculadora de puntuación avanzada para aterrizajes: combina velocidad de impacto, ángulo de la nave y multiplicador de la plataforma de aterrizaje.
- Multiplicadores de puntuación por plataforma (`LandingPad`) para incentivar aterrizajes precisos.
- Pickups de combustible que recargan el tanque y monedas que otorgan puntos adicionales.
- Pantalla de resultado de aterrizaje con opciones de continuar o reintentar según el tipo de aterrizaje.
- Menú principal con inicio de partida y salida del juego.
- UI de pausa y ajuste de volumen de sonido y música.
- Gestor de audio para efectos de pickup y música en el juego.
- Registro de tiempo de partida y puntuación acumulada entre niveles.

## Características principales

- Física 2D basada en `Rigidbody2D`.
- Mecánica de combustible y empuje.
- Puntuación por aterrizajes suaves y por recogida de monedas.
- Diferentes tipos de fracaso: aterrizaje en zona incorrecta, ángulo demasiado pronunciado, velocidad excesiva.
- Integración con Unity Input System.
- Compatibilidad con teclado y gamepad (entrada analógica para movimiento y rotación).
- Interfaz de usuario para estadísticas, puntuación, velocidad y combustible.
- Feedback visual de velocidad mediante flechas direccionales.
- Sistema de pausa con opciones de menú y ajuste de volumen.

## Controles

- `W` o `↑` : Empuje hacia arriba
- `A` o `←` : Girar a la izquierda
- `D` o `→` : Girar a la derecha
- `Esc` : Acceder al menú / pausar y reanudar

Además, el proyecto ofrece compatibilidad con gamepad para dirección y botones de acción.

## Estructura del proyecto

- `Assets/Scenes/` : escenas del juego.
- `Assets/Scripts/` : lógica del juego.
  - `GameManager.cs` : gestión de niveles, puntuación, tiempo y pausa.
  - `SceneLoader.cs` : carga de escenas del juego.
  - `GameInput.cs` : encapsula la entrada de Unity Input System.
  - `GameLevel.cs` : define posiciones de inicio y configuración de cada nivel.
  - `Lander.cs` : control del módulo espacial, consumo de combustible, pickups y lógica de aterrizaje.
  - `LandingPad.cs` : multiplicador de puntuación para plataformas de aterrizaje.
  - `LandedUI.cs` : IU de resultados de aterrizaje y botones de continuar/reintentar.
  - `StatsUI.cs` : indicadores de velocidad, combustible, nivel, puntaje y tiempo.
  - `PausedUI.cs` : IU de pausa y ajustes de audio.
  - `GameOverUI.cs` : IU de fin de partida y puntuación total.
  - `SoundManager.cs` / `MusicManager.cs` : gestión de efectos y música.
  - `LanderVisuals.cs` : efectos visuales y animaciones de la nave.
- `Assets/InputActions.cs` : definición de acciones de control con Unity Input System.
- `ProjectSettings/ProjectVersion.txt` : versión compatible de Unity.

## Requisitos

- Unity 6.0.1f1 (según `ProjectSettings/ProjectVersion.txt`).
- Paquetes de Unity estándar y Input System.
- Cinemachine para el control de cámara.

## Cómo abrir el proyecto

1. Abre Unity Hub.
2. Añade la carpeta del proyecto `Space Mercenaries`.
3. Selecciona la versión de Unity indicada en `ProjectSettings/ProjectVersion.txt`.
4. Abre la escena principal desde `Assets/Scenes/`.

## Nota

Este proyecto está diseñado como un prototipo de juego académico o personal. Puede usarse como base para mejorar:

- niveles y diseño de plataformas,
- objetivos adicionales,
- efectos visuales y sonoros,
- sistema de progresión y menús.
