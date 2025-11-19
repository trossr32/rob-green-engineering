/** @type {import('tailwindcss').Config} */

module.exports = {
    content: ['./**/*.{razor,html}'],

    safelist: ['active'],

    theme: {
        fontFamily: {
            header: ['"Source Sans Pro"', 'sans-serif'],
            body: ['"Open Sans"', 'sans-serif'],
        },

        screens: {
            xs: "375px",
            sm: "640px",
            md: "768px",
            lg: "1024px",
            xl: "1280px",
            "2xl": "1536px",
        },

        colors: {
            transparent: "transparent",
            current: "currentColor",
            primary: "#6aa84f",
            secondary: "#252426",
            white: "#ffffff",
            black: "#000000",
            yellow: "#f9e71c",
            lila: "#e6e5ec",
            "light-green": "#6aa84f",
            "dark-green": "#262f20",
            "light-grey": "#e1e1e1",
            "dark-grey": "#1e1e1e",
            error: "crimson",
            warning: "darkorange",
            "grey-10": "#6c6b6d",
            "grey-20": "#7c7c7c",
            "grey-30": "#919091",
            "grey-40": "#929293",
            "grey-50": "#f4f3f8",
            "grey-60": "#edebf6",
            "grey-70": "#d8d8d8",
            "hero-gradient-from": "rgba(85, 64, 174, 0.95)",
            "hero-gradient-to": "rgba(65, 47, 144, 0.93)",
            "blog-gradient-from": "#8f9098",
            "blog-gradient-to": "#222222",
        },

        // Container – v4 removed the built-in container plugin
        container: {
            center: true,
            padding: "1rem",
        },

        // Box shadows
        boxShadow: {
            DEFAULT: "0 2px 18px rgba(0, 0, 0, 0.06)",
            md: "0 -3px 36px rgba(0, 0, 0, 0.12)",
        },

        // z-index
        zIndex: {
            "-1": "-1",
            "60": "60",
            "70": "70",
        },

        // maxWidth
        maxWidth: {
            'main-logo': '900px',
            'the-ton': '1000px',
        },

        // lineHeight
        lineHeight: {
            inherit: 'inherit',
        },

        // Custom animation
        animation: {
            fadeIn: 'fadeIn 0.5s ease-out',
            ping: 'ping 1s cubic-bezier(0, 0, 0.2, 1) infinite',
        },

        keyframes: {
            fadeIn: {
                from: { opacity: '0' },
                to: { opacity: '1' },
            },
            ping: {
                '75%, 100%': {
                    transform: 'scale(2)',
                    opacity: '0',
                },
            },
        },
    },

    plugins: [
        require('@tailwindcss/typography'),
        require('@tailwindcss/forms'),
        require('@tailwindcss/aspect-ratio'),
    ],
};