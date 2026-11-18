Tutorial #7

I wanted to make a decal shader that slides for the purpose of using it to make a character tattoo move as if it was alive. 
I was going to make it so it moves in the Y direction by using the code in Hologram shaders that take care of the line movements and tweaking it a little.
However, it wasn't working correctly so I changed it a little.

<img width="1005" height="482" alt="Screenshot 2026-11-11 121640" src="https://github.com/user-attachments/assets/9ef2c94e-0129-4665-adbc-9d025b3776a2" />

As shown in the image, I made a variable to hold the current value for which the UV should move. I multiplied the _Time.y and _LineSpeed with 0.1 because the decal was moving too fast and I had to put the speed to 0.1 in the inspector anyway.

<img width="907" height="527" alt="Screenshot 2026-11-11 122239" src="https://github.com/user-attachments/assets/d95a5c81-93d4-47c1-9120-b0254738c6db" />

It doesn't look exactly how I wanted it to look. The decal split itself at the back of the model and moved separately. I believe that is because of the model and decal texture not the shader.
