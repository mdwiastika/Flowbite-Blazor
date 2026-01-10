/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./**/*.razor",
        "./**/*.html",
        "./wwwroot/**/*.js"
    ],
    theme: {
        extend: {
            fontFamily: {
                sans: ['Outfit', 'ui-sans-serif', 'system-ui'],
            },
        },
    },
    plugins: [],
}
