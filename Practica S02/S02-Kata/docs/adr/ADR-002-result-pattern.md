# ADR-002 — Result<T> para errores de validación de negocio

**Status:** Accepted
**Date:** 2026-05-XX
**Deciders:** Desarrollador backend

## Contexto

<!-- ¿Qué problema llevó a esta decisión? Describe sin mencionar la solución elegida.       -->
<!-- Pista: ¿qué pasa cuando Price.Create() recibe un decimal inválido?                    -->
<!-- Opciones a comparar: throw ArgumentException, retornar null/default, retornar Result<T>-->

Sucedio que el metodo Create() de la clase Price tenia la flexibilidad
de que permita culaquier decimal, sin embargo, no estaba limitado por reglas de negocio.

## Decisión

<!-- ¿Qué elegiste? ¿Qué alternativa descartaste y por qué?                                -->
<!-- Pista: ¿para qué están las exceptions? ¿qué fuerza al llamador a manejar el error?    -->
<!--        ¿cómo se ve el call site con cada opción?    -->

se opto por retornar un generico llamado Result<Price> para que que se
maneje el error de manera controlada en vez de un try catch mas largo, se omitio un if ternario
ya que iba a verse muy largo y ademasla estrcuura if convencial se ve mas limpia en este caso.

## Consecuencias

**Positivas:**
- <!-- Al menos 1 consecuencia real -->
- Logica de negocio mas explicta en codigo
- Estrcutura de control mas limpia

**Negativas:**
- <!-- Al menos 1 consecuencia real -->
- se requirio un generico para amnejar el error, lo cual es un tema relativamente avanzado
- se requirio un nuevo tipo de dato para manejar el errr