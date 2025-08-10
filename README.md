# Resize-and-Scale-Controls
A lightweight, reusable helper for making WinForms applications fully responsive — automatically resizing, repositioning, and scaling fonts for all controls, including nested ones, when the form size changes.

# Features
- Automatic control resizing — Adjusts width & height proportionally.
- Dynamic repositioning — Keeps layouts looking neat at any resolution.
- Font scaling — Text grows/shrinks in sync with the form.
- Minimal integration — Just two method calls (InitializeResize & ApplyResize).
- Recursive support — Works for all nested controls.

# Quick Start
```
csharp

// Form1_Load
ResizeHelper.InitializeResize(this);

// Form1_Resize
ResizeHelper.ApplyResize(this);
```

# How It Works
1. Capture the original form size, control sizes, positions, and fonts.
2. Calculate scaling ratios based on the new form dimensions.
3. Apply proportional resizing, repositioning, and font scaling to each control.

# License
This project is released under the MIT License. You’re free to use, modify, and distribute it.
