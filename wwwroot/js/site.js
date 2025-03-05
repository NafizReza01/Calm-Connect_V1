// wwwroot/js/site.js
document.addEventListener('DOMContentLoaded', function () {
    const elements = document.querySelectorAll('.fade-element');

    function handleScroll() {
        const windowHeight = window.innerHeight;

        elements.forEach(element => {
            const rect = element.getBoundingClientRect();

            // Check if element is in viewport
            if (rect.top < windowHeight && rect.bottom >= 0) {
                // Element is entering or in viewport
                element.classList.remove('fade-out');
                element.classList.add('fade-in');
            } else {
                // Element is leaving viewport
                element.classList.remove('fade-in');
                element.classList.add('fade-out');
            }
        });
    }

    // Debounce function to improve performance
    function debounce(func, wait) {
        let timeout;
        return function executedFunction(...args) {
            const later = () => {
                clearTimeout(timeout);
                func(...args);
            };
            clearTimeout(timeout);
            timeout = setTimeout(later, wait);
        };
    }

    const debouncedHandleScroll = debounce(handleScroll, 100); // 100ms debounce
    window.addEventListener('scroll', debouncedHandleScroll);
    handleScroll(); // Initial check on page load
});

