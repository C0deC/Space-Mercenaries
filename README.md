# Space Mercenaries

Juego 2D desarrollado en Unity, inspirado en el clásico estilo "lunar lander". El objetivo es pilotar una nave espacial y aterrizar suavemente en plataformas mientras gestionas combustible, recoges monedas y evitas impactos bruscos.

## Descripción

Space Mercenaries es un prototipo de videojuego que combina físicas 2D con mecánicas de vuelo y aterrizaje. El jugador controla un módulo espacial que debe:

- Mantener el combustible bajo control.
- Girar y usar propulsores para estabilizar la nave.
- Aterrizar en plataformas seguras.
- Evitar aterrizajes demasiado rápidos, con ángulos incorrectos o fuera de la zona de aterrizaje.
- Recoger monedas y potenciadores de combustible.

## Características principales

- Física 2D basada en `Rigidbody2D`.
- Mecánica de combustible y empuje.
- Puntuación por aterrizajes suaves y por recogida de monedas.
- Diferentes tipos de fracaso: aterrizaje en zona incorrecta, ángulo demasiado pronunciado, velocidad excesiva.
- Integración con Unity Input System.
- Interfaz de usuario para estadísticas, puntuación y estado del aterrizaje.

## Controles

- `W` o `↑` : Empuje hacia arriba
- `A` o `←` : Girar a la izquierda
- `D` o `→` : Girar a la derecha
- `Esc` : Acceder al menú

Además, el proyecto ofrece compatibilidad con gamepad para dirección y botones de acción.

## Estructura del proyecto

- `Assets/Scenes/` : escenas del juego.
- `Assets/Scripts/` : lógica del juego.
  - `Lander.cs` : control del módulo espacial y evaluación del aterrizaje.
  - `GameManager.cs` : gestión de puntuación y tiempo.
  - `LanderVisuals.cs` : VFX y animaciones de la nave.
  - `LandedUI.cs` : IU de aterrizaje.
  - `StatsUI.cs` : indicadores de velocidad y combustible.
- `Assets/InputActions.cs` : definición de acciones de control con Unity Input System.
- `ProjectSettings/ProjectVersion.txt` : versión compatible de Unity.

## Requisitos

- Unity 6.0.1f1 (según `ProjectSettings/ProjectVersion.txt`).
- Paquetes de Unity estándar y Input System.

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
