# 🧩 Fase 1 — Mapa Conceitual de Evolução

**Problema:** Formatar texto com diferentes modos (maiúsculo, minúsculo, título, reverso).

---

## 🔹 Quadro 1 — Versão Procedural

Tudo está em uma única função, cheia de `if` e `switch`.

Exemplo:
```csharp
switch (modo)
{
    case 1: return texto.ToUpper();
    case 2: return texto.ToLower();
    ...
}

