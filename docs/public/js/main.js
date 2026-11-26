(function () {
  'use strict';

  var doc = document;
  var header = doc.querySelector('.site-header');
  var navToggle = doc.querySelector('.nav-toggle');
  var mobileNav = doc.getElementById('mobileNav');
  var navLinks = Array.prototype.slice.call(doc.querySelectorAll('.nav-links a'));
  var reduceMotion = window.matchMedia('(prefers-reduced-motion: reduce)').matches;

  /* Header con sombra al hacer scroll
     ---------------------------------------------------------------------- */
  function onScrollHeader() {
    if (!header) return;
    header.classList.toggle('is-scrolled', window.scrollY > 12);
  }

  /* Menú móvil
     ---------------------------------------------------------------------- */
  function setMenu(open) {
    if (!navToggle || !mobileNav) return;
    navToggle.setAttribute('aria-expanded', open ? 'true' : 'false');
    navToggle.setAttribute('aria-label', open ? 'Cerrar menú' : 'Abrir menú');
    mobileNav.hidden = !open;
    mobileNav.classList.toggle('is-open', open);
    doc.body.classList.toggle('nav-open', open);
  }

  if (navToggle && mobileNav) {
    navToggle.addEventListener('click', function () {
      setMenu(navToggle.getAttribute('aria-expanded') !== 'true');
    });

    mobileNav.addEventListener('click', function (event) {
      if (event.target.closest('a')) setMenu(false);
    });

    doc.addEventListener('keydown', function (event) {
      if (event.key === 'Escape' && navToggle.getAttribute('aria-expanded') === 'true') {
        setMenu(false);
        navToggle.focus();
      }
    });

    window.addEventListener('resize', function () {
      if (window.innerWidth > 991 && navToggle.getAttribute('aria-expanded') === 'true') {
        setMenu(false);
      }
    });
  }

  /* Scrollspy
     ---------------------------------------------------------------------- */
  var spySections = navLinks
    .map(function (link) {
      var id = link.getAttribute('href');
      return id && id.charAt(0) === '#' ? doc.getElementById(id.slice(1)) : null;
    })
    .filter(Boolean);

  function updateSpy() {
    if (!spySections.length) return;
    var offset = (header ? header.offsetHeight : 78) + 48;
    var current = null;

    for (var i = 0; i < spySections.length; i += 1) {
      if (spySections[i].getBoundingClientRect().top <= offset) {
        current = spySections[i];
      }
    }

    navLinks.forEach(function (link) {
      var isCurrent = current && link.getAttribute('href') === '#' + current.id;
      link.classList.toggle('is-active', Boolean(isCurrent));
      if (isCurrent) {
        link.setAttribute('aria-current', 'true');
      } else {
        link.removeAttribute('aria-current');
      }
    });
  }

  /* Animaciones de entrada
     ---------------------------------------------------------------------- */
  var revealItems = Array.prototype.slice.call(doc.querySelectorAll('[data-reveal]'));

  if (reduceMotion || !('IntersectionObserver' in window)) {
    revealItems.forEach(function (item) {
      item.classList.add('is-visible');
    });
  } else {
    var revealObserver = new IntersectionObserver(
      function (entries) {
        entries.forEach(function (entry) {
          if (entry.isIntersecting) {
            entry.target.classList.add('is-visible');
            revealObserver.unobserve(entry.target);
          }
        });
      },
      { rootMargin: '0px 0px -8% 0px', threshold: 0.08 }
    );

    revealItems.forEach(function (item) {
      revealObserver.observe(item);
    });
  }

  /* Botón volver arriba
     ---------------------------------------------------------------------- */
  var backToTop = doc.querySelector('.back-to-top');

  function onScrollTopButton() {
    if (!backToTop) return;
    backToTop.classList.toggle('is-visible', window.scrollY > 600);
  }

  if (backToTop) {
    backToTop.addEventListener('click', function () {
      window.scrollTo({ top: 0, behavior: reduceMotion ? 'auto' : 'smooth' });
    });
  }

  /* CTA móvil: se oculta al llegar a la descarga
     ---------------------------------------------------------------------- */
  var mobileCta = doc.getElementById('mobileCta');
  var downloadSection = doc.getElementById('descarga');

  if (mobileCta && downloadSection && 'IntersectionObserver' in window) {
    var ctaObserver = new IntersectionObserver(
      function (entries) {
        entries.forEach(function (entry) {
          mobileCta.classList.toggle('is-hidden', entry.isIntersecting);
        });
      },
      { threshold: 0.2 }
    );
    ctaObserver.observe(downloadSection);
  }

  /* FAQ: solo una respuesta abierta a la vez
     ---------------------------------------------------------------------- */
  var faqItems = Array.prototype.slice.call(doc.querySelectorAll('.faq-item'));

  faqItems.forEach(function (item) {
    item.addEventListener('toggle', function () {
      if (!item.open) return;
      faqItems.forEach(function (other) {
        if (other !== item) other.open = false;
      });
    });
  });

  /* Copiar enlace
     ---------------------------------------------------------------------- */
  var copyButton = doc.querySelector('[data-copy]');

  function copyText(text) {
    if (navigator.clipboard && window.isSecureContext) {
      return navigator.clipboard.writeText(text);
    }

    return new Promise(function (resolve, reject) {
      var area = doc.createElement('textarea');
      area.value = text;
      area.setAttribute('readonly', '');
      area.style.position = 'fixed';
      area.style.opacity = '0';
      doc.body.appendChild(area);
      area.select();

      try {
        doc.execCommand('copy') ? resolve() : reject();
      } catch (error) {
        reject(error);
      } finally {
        doc.body.removeChild(area);
      }
    });
  }

  if (copyButton) {
    var copyLabel = copyButton.querySelector('.copy-label');
    var originalLabel = copyLabel ? copyLabel.textContent : '';

    copyButton.addEventListener('click', function () {
      copyText(copyButton.getAttribute('data-copy') || window.location.href)
        .then(function () {
          if (copyLabel) copyLabel.textContent = '¡Enlace copiado!';
          window.setTimeout(function () {
            if (copyLabel) copyLabel.textContent = originalLabel;
          }, 2200);
        })
        .catch(function () {
          if (copyLabel) copyLabel.textContent = 'No se pudo copiar';
          window.setTimeout(function () {
            if (copyLabel) copyLabel.textContent = originalLabel;
          }, 2200);
        });
    });
  }

  /* Año del footer
     ---------------------------------------------------------------------- */
  var year = doc.getElementById('year');
  if (year) year.textContent = new Date().getFullYear();

  /* Eventos de scroll agrupados
     ---------------------------------------------------------------------- */
  var ticking = false;

  function onScroll() {
    if (ticking) return;
    ticking = true;

    window.requestAnimationFrame(function () {
      onScrollHeader();
      onScrollTopButton();
      updateSpy();
      ticking = false;
    });
  }

  window.addEventListener('scroll', onScroll, { passive: true });
  window.addEventListener('resize', onScroll);

  onScrollHeader();
  onScrollTopButton();
  updateSpy();
})();
