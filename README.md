# 📌 Resize and Scale Controls

A simple, reusable utility for **automatic resizing and scaling of controls** in WinForms applications. Designed to keep layouts clean, fonts proportional, and controls positioned correctly as the form is resized.

![ResizeControls](https://github.com/user-attachments/assets/9b10a91b-c0de-4d93-807d-f9d49433cd41)

# 💡 Reason for Development
During my work in automation and custom application development, I often needed to create desktop UIs with flexible layouts in a fast-paced enviroment. In a factory various DPI screen sizes are often encountered, some of which needs to run the same application.

The problem? WinForms are ideal for creating UIs quickly, but lacks the ability to natively handle **responsive design** - resizing a form usually results in misplaced controls, distorted propertions, and inconsistent font scaling.

I build this utility to:

- Save **development time** by removing the need to manually adjust controls for every form size.
- Maintain a **professional UI** without complicated layout logic.
- Provide a **reusable solution** that can be easily be dropped into any WinForms project.

This utility tool grew out of a practical need to make application development faster, cleaner, and less frustrating — and now it’s part of my toolkit for any WinForms-based application.

# ✨ Features
- **Automatic control resizing** — Adjusts width & height proportionally.
- **Dynamic repositioning** — Keeps layouts looking neat at any resolution.
- **Font scaling** — Text grows/shrinks in sync with the form.
- **Minimal integration** — Just two method calls (InitializeResize & ApplyResize).
- **Recursive support** — Works for all nested controls.

# 🚀 Quick Start
```
csharp

// Form1_Load
ResizeHelper.InitializeResize(this);

// Form1_Resize
ResizeHelper.ApplyResize(this);
```

# 🔧 How It Works
1. Capture the original form size, control sizes, positions, and fonts.
2. Calculate scaling ratios based on the new form dimensions.
3. Apply proportional resizing, repositioning, and font scaling to each control.

# 📜 License
This project is released under the MIT License. You’re free to use, modify, and distribute it.
