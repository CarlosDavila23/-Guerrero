# 🗡️ Pseudocódigo - Entrenamiento de Guerrero

Este pseudocódigo modela un pequeño sistema interactivo donde un jugador controla un **guerrero** que puede entrenar, pelear, descansar y subir de nivel según la experiencia obtenida.

## 🎯 Objetivo
Simular el ciclo de entrenamiento y combate de un guerrero, administrando atributos como **fuerza**, **resistencia**, **energía**, **experiencia** y **nivel**.

---

## 📋 Variables iniciales

- **fuerza** (`int`) ← 10  
- **resistencia** (`int`) ← 10  
- **energia** (`int`) ← 100  
- **experiencia** (`int`) ← 0  
- **nivel** (`int`) ← 1  
- **seguirJugando** (`bool`) ← `true`  

---

## 🔄 Lógica principal

Mientras `seguirJugando` sea `true`, el programa mostrará un menú con opciones:

1. **Ver estado** → Muestra valores actuales de todos los atributos.
2. **Entrenar fuerza** → El usuario ingresa horas de entrenamiento (máximo 6).  
   - Aumenta fuerza por hora.  
   - Disminuye energía por hora.  
   - Aumenta experiencia.
3. **Entrenar resistencia** → Igual que entrenar fuerza, pero mejora la resistencia.
4. **Pelear** → Si hay al menos 20 de energía:  
   - Resultado aleatorio: si gana, aumenta experiencia; si pierde, pierde más energía.  
   - Si no hay energía suficiente, muestra advertencia.
5. **Descansar** → Permite recuperar energía según horas de descanso (máximo 6).
6. **Salir** → Cambia `seguirJugando` a `false` para terminar.

---

## 🆙 Subida de nivel

Después de cada acción, el programa verifica si la experiencia es suficiente para subir de nivel:
- Si `experiencia ≥ 100`:  
  - **nivel** aumenta en 1  
  - **experiencia** se reinicia a 0  
  - **fuerza** y **resistencia** aumentan

---



--- 

## 📝 Notas

- Los valores de aumento/disminución por hora pueden ajustarse según el diseño del juego.  
- El sistema asegura que las horas de entrenamiento y descanso no excedan 6.  
- La energía funciona como un **recurso limitado** para balancear las acciones.  

---
